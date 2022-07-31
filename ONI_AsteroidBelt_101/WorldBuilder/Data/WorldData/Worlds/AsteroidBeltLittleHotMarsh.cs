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
    internal class AsteroidBeltLittleHotMarsh: WorldSetter
    {
        protected override List<CommonBiomeData> GetBiomes()
        {
            return new List<CommonBiomeData> { new LittleOilBiome().DefaultBiomeData };
        }

        protected override List<Template> GetTemplates()
        {
            return new List<Template> {
                new Template() { Name = "geysers/molten_gold", Max = 2, Min = 1 },
                new Template() { Name = "expansion1::poi/sap_tree_room", Max = 1, Min = 1 }

            };
        }

        protected override string GetName()
        {
            return "AsteroidBeltLittleHotMarsh";
        }

        protected override string GetDescription()
        {
            return "饥饿的泥潭，准备好喂饱它了吗？";
        }

        protected override List<string> GetFixedTraits()
        {
            return new List<string> { "sunlightVeryLow", "cosmicRadiationVeryLow" };
        }



        protected override CommonWorldData GetWorldData()
        {
            return new CommonWorldData() { AllowedRingsMax = 10, AllowedRingsMin = 7, Buffer = 4, World = World };
        }
    }
}
