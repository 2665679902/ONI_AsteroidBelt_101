using ONI_AsteroidBelt_101.Common;
using static ONI_AsteroidBelt_101.WorldBuilder.ConfigData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ONI_AsteroidBelt_101.Loger;

namespace ONI_AsteroidBelt_101.WorldBuilder.Data
{
    internal static class Patch
    {
        public static void Load()
        {
            InJectData();

            Log.Debug("worlds message Load over");
        }

        public static void InJectData()
        {
            StringsInjecter.Inject($"STRINGS.CLUSTER_NAMES.{CurrentCluster.Name.ToUpperInvariant()}.NAME", "小行星带");

            StringsInjecter.Inject($"STRINGS.CLUSTER_NAMES.{CurrentCluster.Name.ToUpperInvariant()}.DESCRIPTION", CurrentCluster.Description);

            foreach (var world in CurrentCluster.StartWorld)
            {
                StringsInjecter.Inject($"STRINGS.WORLDS.{world.World.Name.ToUpper()}.NAME", world.World.Name);
                StringsInjecter.Inject($"STRINGS.WORLDS.{world.World.Name.ToUpper()}.DESCRIPTION", world.World.Description);
            }

            foreach (var world in CurrentCluster.InnerCluster)
            {
                StringsInjecter.Inject($"STRINGS.WORLDS.{world.World.Name.ToUpper()}.NAME", world.World.Name);
                StringsInjecter.Inject($"STRINGS.WORLDS.{world.World.Name.ToUpper()}.DESCRIPTION", world.World.Description);
            }

            foreach (var world in CurrentCluster.OuterWorlds)
            {
                StringsInjecter.Inject($"STRINGS.WORLDS.{world.World.Name.ToUpper()}.NAME", world.World.Name);
                StringsInjecter.Inject($"STRINGS.WORLDS.{world.World.Name.ToUpper()}.DESCRIPTION", world.World.Description);
            }

        }

    }
}
