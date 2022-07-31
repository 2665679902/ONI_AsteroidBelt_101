using ONI_AsteroidBelt_101.WorldBuilder.Common.Biome;
using ONI_AsteroidBelt_101.WorldBuilder.Common.BiomeDiscribe;
using ONI_AsteroidBelt_101.WorldBuilder.Common.Items;
using ONI_AsteroidBelt_101.WorldBuilder.Common.WorldDiscribe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONI_AsteroidBelt_101.WorldBuilder.Common.World
{
    internal class CommonWorld: BaseWorld
    {
        public CommonWorld(int height, int width, List<CommonBiomeData> biomes, List<Template> templates, string name, string description, List<string> fixedTraits) : base(height, width,new List<BaseBiomeData>( biomes.Select(commonBiomeData => commonBiomeData as BaseBiomeData )), templates, name, description, fixedTraits)
        {
            Biomes = biomes;
        }

        public new List<CommonBiomeData> Biomes { get; set; } = new List<CommonBiomeData>();
    }
}
