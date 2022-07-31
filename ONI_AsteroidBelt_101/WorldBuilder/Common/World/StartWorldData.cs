using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONI_AsteroidBelt_101.WorldBuilder.Common.World
{
    internal class StartWorldData: CommonWorldData
    {
        public new StartWorld World { get => base.World as StartWorld; set => base.World = value; }
    }
}
