using ONI_AsteroidBelt_101.WorldBuilder.Common.BiomeDiscribe;
using ONI_AsteroidBelt_101.WorldBuilder.Common.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONI_AsteroidBelt_101.WorldBuilder.Common.WorldDiscribe
{
    internal class BaseWorld
    {
        public BaseWorld(int height, int width, List<BaseBiomeData> biomes, List<Template> templates, string name, string description, List<string> fixedTraits)
        {
            Height = height;
            Width = width;
            Biomes = biomes;
            Templates = templates;
            Name = name;
            Description = description;
            FixedTraits = fixedTraits;
        }


        /// <summary>
        /// 世界的高度
        /// </summary>
        public int Height { get; set; }

        /// <summary>
        /// 世界的宽度
        /// </summary>
        public int Width { get; set; }

        /// <summary>
        /// 世界包含的生态
        /// </summary>
        public List<BaseBiomeData> Biomes { get; set; } = new List<BaseBiomeData>();

        /// <summary>
        /// 世界里包含的模板
        /// </summary>
        public List<Template> Templates { get; set; } = new List<Template>();

        /// <summary>
        /// 世界的名字
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 世界的描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 是否有补充条款
        /// </summary>
        public List<string> FixedTraits { get; set; } = new List<string>();
    }
}
