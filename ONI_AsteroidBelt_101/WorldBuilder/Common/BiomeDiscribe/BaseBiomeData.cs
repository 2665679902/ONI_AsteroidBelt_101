using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONI_AsteroidBelt_101.WorldBuilder.Common.BiomeDiscribe
{
    internal class BaseBiomeData
    {
        /// <summary>
        /// 描述的生态对象
        /// </summary>
        public BaseBiome BiomeType { get; set; }

        /// <summary>
        /// 包含该生态的格子
        /// </summary>
        public HashSet<Vector2I> Cells { get; set; } = new HashSet<Vector2I>();
    }
}
