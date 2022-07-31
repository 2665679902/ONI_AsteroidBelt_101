using static ONI_AsteroidBelt_101.Common.Configs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONI_AsteroidBelt_101.Common
{
    internal static class StringsInjecter
    {
        public static void Load()
        {
            
        }



        public static void Inject( params string[] strings)
        {
            Strings.Add(strings);
        }
    }
}
