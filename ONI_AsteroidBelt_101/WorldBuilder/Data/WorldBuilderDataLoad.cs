using ONI_AsteroidBelt_101.WorldBuilder.Data.FileManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONI_AsteroidBelt_101.WorldBuilder.Data
{
    internal static class WorldBuilderDataLoad
    {
        public static void Load()
        {
            Patch.Load();
            FileLoad.Load();
        }
    }
}
