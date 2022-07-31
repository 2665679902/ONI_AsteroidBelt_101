using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONI_AsteroidBelt_101.WorldBuilder.Common.WorldDiscribe
{
    internal class BaseCluster
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string CoordinatePrefix { get; set; }

        public int MenuOrder { get; set; }

        public int ClusterCategory { get; set; }

        public int Difficulty { get; set; }

        public int StartWorldIndex { get; set; }

        public int NumRings { get; set; }

        public List<BaseWorldData> StartWorld { get; set; }

        public List<BaseWorldData> InnerCluster { get; set; }

        public List<BaseWorldData> OuterWorlds { get; set; }

        public List<BasepoiData> PoiPlacements { get; set; }
    }
}
