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
    internal class AsteroidBeltLittleRust: WorldSetter
    {
        protected override List<CommonBiomeData> GetBiomes()
        {
            return new List<CommonBiomeData> { new LittleRustBiome().DefaultBiomeData };
        }

        protected override List<Template> GetTemplates()
        {
            return new List<Template> {
                new Template() { Name = "geysers/molten_iron", Max = 2, Min = 1 }
            };
        }

        protected override string GetName()
        {
            return "AsteroidBeltLittleRust";
        }

        protected override string GetDescription()
        {
            return "这个地方以前是一颗金属星，但是现在生锈了";
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
