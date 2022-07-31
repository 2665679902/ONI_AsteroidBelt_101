using PeterHan.PLib.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONI_AsteroidBelt_101.UI
{
    internal static class UIPatch
    {
        public static void Load(KMod.UserMod2 userMod)
        {
            new POptions().RegisterOptions(userMod, typeof(OptionMenuForPLib));

        }




    }
}
