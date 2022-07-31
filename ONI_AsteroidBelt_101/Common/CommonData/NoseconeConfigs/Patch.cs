using Database;
using HarmonyLib;
using ONI_AsteroidBelt_101.Loger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TUNING;

namespace ONI_AsteroidBelt_101.Common.CommonData.NoseconeConfigs
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
                Log.Debug("Nosecone: GeneratedBuildings -Prefix");
                AddBuildingStrings(ConfigFile.ID, "LowTech Nosecone"," You need to pay more for early consumption" ," It can work as well as the Basic one " );
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
                Log.Debug("Nosecone: Techs -Postfix");
                __instance.TryGetTechForTechItem("HabitatModuleSmall").unlockedItemIDs.Add(ConfigFile.ID);
            }
        }

    }
}
