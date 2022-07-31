using HarmonyLib;
using ONI_AsteroidBelt_101.Loger;
using ProcGenGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONI_AsteroidBelt_101.WorldBuilder.Creator
{
    internal class Patch
    {

        /// <summary>
        /// 捕获地图生成结果
        /// </summary>
        [HarmonyPatch(typeof(WorldGen), "RenderOffline")]
        public static class WorldGen_RenderOffline_Patch
        {
            public static bool Prefix(WorldGen __instance, ref bool __result, ref Sim.Cell[] cells, ref Sim.DiseaseCell[] dc, int baseId)
            {

                Log.Debug("-------------------世界生成函数捕获----------------------");
                Log.Debug($"Size  X: {__instance.World.size.X}    Y: {__instance.World.size.Y}");
                return !(ConfigData.IsAsteroidBelt && Creator.Catch(__instance, ref __result, ref cells, ref dc, baseId));
            }

            public static void Postfix()
            {
                Log.Debug("捕获结束");
            }
        }


        [HarmonyPatch(typeof(Cluster), "BeginGeneration")]
        public static class BeginGenerationPatch
        {
            public static void Prefix()
            {
                Creator.CommonWorldReLoad();
            }
        }
    }
}
