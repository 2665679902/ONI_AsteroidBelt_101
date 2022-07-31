using ONI_AsteroidBelt_101.WorldBuilder.Common.Biome;
using ONI_AsteroidBelt_101.WorldBuilder.Common.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONI_AsteroidBelt_101.WorldBuilder.Common.World
{
    internal class StartWorld: CommonWorld
    {
        public StartWorld(int height, int width, List<CommonBiomeData> biomes, List<Template> templates, string name, string description, List<string> fixedTraits, string startingTemplate, List<Things> startingItems) : base(height, width, biomes, templates, name, description, fixedTraits)
        {
            StartingItems = startingItems;
            StartingTemplate = startingTemplate;
        }

        /// <summary>
        /// 要在开局的时候直接刷在地上的物品 -> 物品名字：数量
        /// </summary>
        public List<Things> StartingItems { get; set; } = new List<Things>();

        //开始世界的中心点
        public Vector2I Center { get; set; } = new Vector2I(0, 0);
        //开始世界的模型
        public string StartingTemplate { private get; set; }
        //获得模型
        public TemplateContainer GetStartingTemplate() { return TemplateCache.GetTemplate(StartingTemplate); }
    }
}
