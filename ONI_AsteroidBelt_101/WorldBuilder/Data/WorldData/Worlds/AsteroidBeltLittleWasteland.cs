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
    internal class AsteroidBeltLittleWasteland: WorldSetter
    {
        protected override List<CommonBiomeData> GetBiomes()
        {
            return new List<CommonBiomeData> { new LittleWastelandBiome().DefaultBiomeData };
        }

        protected override List<Template> GetTemplates()
        {
            return new List<Template> {
                new Template() { Name = "expansion1::geysers/liquid_sulfur", Max = 2, Min = 1 }
            };
        }

        protected override string GetName()
        {
            return "AsteroidBeltLittleWasteland";
        }

        protected override string GetDescription()
        {
            return "破碎的荒野上还有一些坚强的生命";
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
