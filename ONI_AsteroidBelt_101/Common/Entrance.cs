using HarmonyLib;
using ONI_AsteroidBelt_101.Common.CommomData;
using ONI_AsteroidBelt_101.Loger;
using ONI_AsteroidBelt_101.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONI_AsteroidBelt_101.Common
{
    internal class Entrance : KMod.UserMod2
    {
        public override void OnLoad(Harmony harmony)
        {
            string modPath = mod.ContentPath.Replace('/', '\\');

            base.OnLoad(harmony);

            Log.Load(modPath,DegubInterface:false);

            Log.UnAble = true;

            FileLoader.Load(modPath);

            StringsInjecter.Load();

            UIPatch.Load(this);

            CommomDataLoad.Load();






            //Log.Debug("OnLoad");
        }




    }
}
