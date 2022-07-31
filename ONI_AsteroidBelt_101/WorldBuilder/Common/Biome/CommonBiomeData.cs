using ONI_AsteroidBelt_101.WorldBuilder.Common.BiomeDiscribe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONI_AsteroidBelt_101.WorldBuilder.Common.Biome
{
    internal class CommonBiomeData:BaseBiomeData
    {
        public new CommonBiome BiomeType { get => base.BiomeType as CommonBiome; set => base.BiomeType = value; }

        public BiomeBehaviorPattern BehaviorPattern { get; set; }

        public BiomeLocationPattern LocationPattern { get; set; }
    }
}
