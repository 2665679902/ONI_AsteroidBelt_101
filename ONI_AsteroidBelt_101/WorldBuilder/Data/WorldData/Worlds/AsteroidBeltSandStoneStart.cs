using ONI_AsteroidBelt_101.WorldBuilder.Common.Biome;
using ONI_AsteroidBelt_101.WorldBuilder.Common.Items;
using ONI_AsteroidBelt_101.WorldBuilder.Common.World;
using ONI_AsteroidBelt_101.WorldBuilder.Data.BiomeData.Biomes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONI_AsteroidBelt_101.WorldBuilder.Data.WorldData.Worlds
{
    internal class AsteroidBeltSandStoneStart : StartWorldSetter
    {
        protected override List<CommonBiomeData> GetBiomes()
        {
            return new List<CommonBiomeData> { new LittleSandStoneBiome().DefaultBiomeData};
        }

        protected override List<Template> GetTemplates()
        {
            return new List<Template> {
                new Template() { Name = "expansion1::poi/warp/teleporter", Max = 1, Min = 1 } ,
                new Template() { Name = "expansion1::poi/warp/sender", Max = 1, Min = 1 } ,
                new Template() { Name = "expansion1::poi/warp/receiver", Max = 1, Min = 1 } ,
                new Template() { Name = "expansion1::poi/poi_geyser_dirty_slush", Max = 1, Min = 1 }
            };
        }

        protected override string GetName()
        {
            return "AsteroidBeltSandStoneStart";
        }

        protected override string GetDescription()
        {
            return "一个摇摇欲坠的小土丘，记得带上你的老鼠！和哈奇？";
        }

        protected override List<string> GetFixedTraits()
        {
            return new List<string> { "sunlightVeryLow", "cosmicRadiationVeryLow" };
        }

        protected override StartWorldData GetStartWorldData()
        {
            return new StartWorldData() { AllowedRingsMax = 0, AllowedRingsMin=0, Buffer = 2, World = World as StartWorld};
        }

        protected override string GetStartingTemplate()
        {
            return "bases/sandstoneBase";
        }

        protected override List<Things> GetStartingItems()
        {
            return new List<Things> { new Things("Gold",2500), new Things("FieldRation",60) };
        }

    }
}
