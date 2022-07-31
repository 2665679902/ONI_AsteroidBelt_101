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
    internal class AsteroidBeltLittleMagma: WorldSetter
    {
        protected override List<CommonBiomeData> GetBiomes()
        {
            CommonBiomeData down = new LittleNiobiumBiome().DefaultBiomeData;
            down.LocationPattern = BiomeLocationPattern.Down;
            down.BehaviorPattern = BiomeBehaviorPattern.LowFull;

            CommonBiomeData mid = new LittleMagmaBiome().DefaultBiomeData;
            mid.LocationPattern = BiomeLocationPattern.Middle;

            CommonBiomeData left = new LittleMagmaBiome().DefaultBiomeData;
            left.LocationPattern = BiomeLocationPattern.Left;

            CommonBiomeData right = new LittleMagmaBiome().DefaultBiomeData;
            right.LocationPattern = BiomeLocationPattern.Right;

            return new List<CommonBiomeData> { new LittleNiobiumBiome().DefaultBiomeData };
        }

        protected override List<Template> GetTemplates()
        {
            return new List<Template> {
                new Template() { Name = "expansion1::geysers/molten_niobium", Max = 2, Min = 1 }
            };
        }

        protected override string GetName()
        {
            return "AsteroidBeltLittleMagma";
        }

        protected override string GetDescription()
        {
            return "这里的地质非常不稳定";
        }

        protected override List<string> GetFixedTraits()
        {
            return new List<string> { "sunlightVeryLow", "cosmicRadiationVeryLow" };
        }



        protected override CommonWorldData GetWorldData()
        {
            return new CommonWorldData() { AllowedRingsMax = 7, AllowedRingsMin = 5, Buffer = 4, World = World };
        }
    }
}
