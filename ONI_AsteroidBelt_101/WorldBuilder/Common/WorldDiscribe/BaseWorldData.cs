using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONI_AsteroidBelt_101.WorldBuilder.Common.WorldDiscribe
{
    internal class BaseWorldData
    {
        public BaseWorld World { get; set; }

        public int Buffer { get; set; }

        public int AllowedRingsMin { get; set; }

        public int AllowedRingsMax { get; set; }

    }
}
