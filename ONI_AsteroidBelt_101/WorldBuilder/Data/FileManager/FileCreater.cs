using ONI_AsteroidBelt_101.Common;
using ONI_AsteroidBelt_101.WorldBuilder.Common.WorldDiscribe;
using static ONI_AsteroidBelt_101.Common.Configs;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONI_AsteroidBelt_101.WorldBuilder.Data.FileManager
{
    internal static class FileCreater
    {
        public static void CreatWorldFile(BaseWorld world)
        {
            FileLoader.WriteIn(@"objects\Worlds", $"{world.Name}.yaml", world.Formate());
        }

        public static void CreatBaseClusterFile(BaseCluster cluster)
        {
            FileLoader.WriteIn(@"worldgen\Clusters", $"{cluster.Name}.yaml", cluster.Formate());
        }
    }
}
