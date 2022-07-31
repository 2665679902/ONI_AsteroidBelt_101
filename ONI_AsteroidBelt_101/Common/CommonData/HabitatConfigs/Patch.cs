

using Database;
using HarmonyLib;
using Klei;
using ONI_AsteroidBelt_101.Loger;
using ProcGen;
using TUNING;

namespace ONI_AsteroidBelt_101.Common.CommonData.HabitatConfigs
{
    internal class Patch
    {
        private static void AddBuildingStrings(string buildingId, string name, string description, string effect)
        {
            StringsInjecter.Inject(new string[]
            {
                "STRINGS.BUILDINGS.PREFABS." + buildingId.ToUpperInvariant() + ".NAME",
                STRINGS.UI.FormatAsLink(name, buildingId)
            });
            StringsInjecter.Inject(new string[]
            {
                "STRINGS.BUILDINGS.PREFABS." + buildingId.ToUpperInvariant() + ".DESC",
                description
            });
            StringsInjecter.Inject(new string[]
            {
                "STRINGS.BUILDINGS.PREFABS." + buildingId.ToUpperInvariant() + ".EFFECT",
                effect
            });
        }

        private static void AddRocketModuleToBuildList(string moduleId, string placebehind = "")
        {
            if (!SelectModuleSideScreen.moduleButtonSortOrder.Contains(moduleId))
            {
                int num = -1;
                if (placebehind != "")
                {
                    num = SelectModuleSideScreen.moduleButtonSortOrder.IndexOf(placebehind);
                }
                int index = (num == -1) ? SelectModuleSideScreen.moduleButtonSortOrder.Count : (num + 1);
                SelectModuleSideScreen.moduleButtonSortOrder.Insert(index, moduleId);
            }
        }


        [HarmonyPatch(typeof(GeneratedBuildings), "LoadGeneratedBuildings")]
        public static class GeneratedBuildings_LoadGeneratedBuildings_Patch
        {
            public static void Prefix()
            {
                Log.Debug("Habitat: GeneratedBuildings -Prefix");

                ROCKETRY.ROCKET_INTERIOR_SIZE = new Vector2I(HabitatData.SpaceWidth, HabitatData.SpaceWidth);
                AddBuildingStrings(ConfigFile.ID, "星舰！"," cost huge" , " huge ");
                int num = BUILDINGS.PLANORDER.FindIndex((PlanScreen.PlanInfo x) => x.category == "Base");
                if (num == -1)
                {
                    return;
                }
                ModUtil.AddBuildingToPlanScreen(new HashedString(num), ConfigFile.ID);
                AddRocketModuleToBuildList(ConfigFile.ID);
            }

        }

        [HarmonyPatch(typeof(Techs), "Init")]
        public static class Database_Techs_Init_Patch
        {
            public static void Postfix(ref Techs __instance)
            {
                Log.Debug("Habitat: Techs -Postfix");
                // 从Techs.Init找就行
                __instance.TryGetTechForTechItem("HabitatModuleSmall").unlockedItemIDs.Add(ConfigFile.ID);
            }
        }

        [HarmonyPatch(typeof(WorldContainer), "PlaceInteriorTemplate")]
        public class PlaceInteriorTemplatePatch
        {
            public static void Postfix(ref WorldContainer __instance, ref string template_name, ref System.Action callback)
            {
                Log.Debug("Habitat: WorldContainer try to PlaceInteriorTemplate -Postfix");

                var overworldCell = Traverse.Create(__instance).Field("overworldCell").GetValue<WorldDetailSave.OverworldCell>();

                overworldCell.zoneType = template_name != "expansion1::interiors/habitat_huge" ? SubWorld.ZoneType.RocketInterior : HabitatData.ZoneType;

            }
        }

        [HarmonyPatch(typeof(ClusterManager), "CreateRocketInteriorWorld")]
        public class CreateRocketInteriorWorldPatch
        {
            public static void Prefix(ref string interiorTemplateName)
            {
                if (interiorTemplateName == "expansion1::interiors/habitat_huge")
                {
                    Log.Debug("Habitat: ClusterManager try to CreateRocketInteriorWorld -Prefix");

                    HabitatLoad.Load();
                }

            }

            public static void Postfix(ref string interiorTemplateName)
            {
                if (interiorTemplateName == "expansion1::interiors/habitat_huge")
                {
                    Log.Debug("Habitat: try to unLoad -Postfix");

                    HabitatLoad.UnLoad();
                }

                ROCKETRY.ROCKET_INTERIOR_SIZE = new Vector2I(32, 32);
            }
        }


    }
}
