using ONI_AsteroidBelt_101.WorldBuilder.Common.Biome;
using ONI_AsteroidBelt_101.WorldBuilder.Common.Items;
using ONI_AsteroidBelt_101.WorldBuilder.Common.World;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONI_AsteroidBelt_101.WorldBuilder.Data.WorldData.Worlds
{
    internal abstract class StartWorldSetter: WorldSetter
    {
        protected override CommonWorld GetWorld()
        {
            int hight = GetHight();

            int width = GetWidth();

            List<CommonBiomeData> biomes = GetBiomes();

            List<Template> templates = GetTemplates();

            string name = GetName();

            string description = GetDescription();

            List<string> fixedTraits = GetFixedTraits();

            string startingTemplate = GetStartingTemplate();

            List<Things> startingItems = GetStartingItems();

            return new StartWorld(hight, width, biomes, templates, name, description, fixedTraits, startingTemplate, startingItems);
        }

        protected abstract StartWorldData GetStartWorldData();

        protected override CommonWorldData GetWorldData()
        {
            return GetStartWorldData();
        }

        protected abstract string GetStartingTemplate();

        protected abstract List<Things> GetStartingItems();
    }
}
