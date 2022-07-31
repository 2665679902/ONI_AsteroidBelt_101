using ONI_AsteroidBelt_101.WorldBuilder.Common.WorldDiscribe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONI_AsteroidBelt_101.WorldBuilder.Common.World
{
    internal class CommonWorldData: BaseWorldData
    {
        public new CommonWorld World { get => base.World as CommonWorld; set => base.World = value; }
    }
}
