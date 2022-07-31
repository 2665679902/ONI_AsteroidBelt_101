using ONI_AsteroidBelt_101.Common;
using ONI_AsteroidBelt_101.Loger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ONI_AsteroidBelt_101.WorldBuilder.ConfigData;

namespace ONI_AsteroidBelt_101.WorldBuilder.Data.FileManager
{
    internal static class FileLoad
    {
        public static void Load()
        {
            FileCreater.CreatBaseClusterFile(CurrentCluster);

            foreach(var world in CurrentCluster.StartWorld)
                FileCreater.CreatWorldFile(world.World);

            foreach (var world in CurrentCluster.InnerCluster)
                FileCreater.CreatWorldFile(world.World);

            foreach (var world in CurrentCluster.OuterWorlds)
                FileCreater.CreatWorldFile(world.World);

            FileLoader.LoadFile(@"objects\Worlds", @"OxygenNotIncluded_Data\StreamingAssets\dlc\expansion1\worldgen\worlds");

        }

        public static void UnLoad()
        {
            FileLoader.Remove(@"objects\Worlds");
        }
    }
}
