using ONI_AsteroidBelt_101.WorldBuilder.Common.Biome;
using ONI_AsteroidBelt_101.WorldBuilder.Common.BiomeDiscribe;
using ONI_AsteroidBelt_101.WorldBuilder.Common.Items;
using ONI_AsteroidBelt_101.WorldBuilder.Common.World;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONI_AsteroidBelt_101.WorldBuilder.Data.WorldData.Worlds
{
    internal abstract class WorldSetter
    {
        protected virtual CommonWorld GetWorld()
        {
            int hight = GetHight();

            int width = GetWidth();

            List<CommonBiomeData> biomes = GetBiomes();

            List<Template> templates = GetTemplates();

            string name = GetName();

            string description = GetDescription();

            List<string> fixedTraits = GetFixedTraits();

            return new CommonWorld(hight, width, biomes, templates, name, description, fixedTraits);
        }

        public CommonWorld World { get => GetWorld(); }

        public CommonWorldData DefaultWorldData { get => GetWorldData(); }

        protected virtual int GetHight() { return 100; }

        protected virtual int GetWidth() { return 90; }

        protected abstract List<CommonBiomeData> GetBiomes();

        protected abstract List<Template> GetTemplates();

        protected abstract string GetName();

        protected abstract string GetDescription();

        protected abstract List<string> GetFixedTraits();

        protected abstract CommonWorldData GetWorldData();

    }



}
