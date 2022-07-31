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
    internal class AsteroidBeltLittleOil : WorldSetter
    {
        protected override List<CommonBiomeData> GetBiomes()
        {
            return new List<CommonBiomeData> { new LittleOilBiome().DefaultBiomeData };
        }

        protected override List<Template> GetTemplates()
        {
            return new List<Template> {
                new Template() { Name = "geysers/oil_drip", Max = 2, Min = 1 }
            };
        }

        protected override string GetName()
        {
            return "AsteroidBeltLittleOil";
        }

        protected override string GetDescription()
        {
            return "很多油！和一个可爱的毛茸茸";
        }

        protected override List<string> GetFixedTraits()
        {
            return new List<string> { "sunlightVeryLow", "cosmicRadiationVeryLow" };
        }

        

        protected override CommonWorldData GetWorldData()
        {
            return new CommonWorldData() { AllowedRingsMax = 5, AllowedRingsMin = 5, Buffer = 4, World = World};
        }
    }
}
