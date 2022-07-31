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
    internal class AsteroidBeltLittleForest : StartWorldSetter
    {
        protected override List<CommonBiomeData> GetBiomes()
        {
            return new List<CommonBiomeData> { new LittleForestBiome().DefaultBiomeData };
        }

        protected override List<Template> GetTemplates()
        {
            return new List<Template> {
                 new Template() { Name = "geysers/big_volcano", Max = 2, Min = 1 }
            };
        }

        protected override string GetName()
        {
            return "AsteroidBeltLittleForest";
        }  

        protected override string GetDescription()
        {
            return "一个小绿洲，有树，没有树鼠";
        }

        protected override List<string> GetFixedTraits()
        {
            return new List<string> { "sunlightVeryLow", "cosmicRadiationVeryLow" };
        }

        protected override StartWorldData GetStartWorldData()
        {
            return new StartWorldData() { AllowedRingsMax = 3, AllowedRingsMin = 3, Buffer = 2, World = World as StartWorld };
        }

        protected override string GetStartingTemplate()
        {
            return "expansion1::bases/warpworldForestBase";
        }

        protected override List<Things> GetStartingItems()
        {
            return new List<Things>();
        }
    }
}
