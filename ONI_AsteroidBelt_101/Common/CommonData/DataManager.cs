using ONI_AsteroidBelt_101.Loger;
using ONI_AsteroidBelt_101.UI;
using ProcGen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ONI_AsteroidBelt_101.UI.OptionMenuForPLibData;

namespace ONI_AsteroidBelt_101.Common.CommonData
{
    internal static class DataManager
    {
        public static class HabitatData
        {
            public static void Load()
            {
                OptionMenuForPLib.Reload();
            }

            public static int Width { get { return OptionMenuForPLib.Instance.SpaceShipWidth; } }

            public static int Hight { get { return OptionMenuForPLib.Instance.SpaceShipHight; } }

            public static SubWorld.ZoneType ZoneType { get {return SwitchToSubWorldZoneType(OptionMenuForPLib.Instance.InteriorzoneType); } }

            private static SubWorld.ZoneType SwitchToSubWorldZoneType(ZoneType type)
            {
                switch (type)
                {
                    case OptionMenuForPLibData.ZoneType.FrozenWastes:
                        return SubWorld.ZoneType.FrozenWastes;
                    case OptionMenuForPLibData.ZoneType.CrystalCaverns:
                        return SubWorld.ZoneType.CrystalCaverns;
                    case OptionMenuForPLibData.ZoneType.BoggyMarsh:
                        return SubWorld.ZoneType.BoggyMarsh;
                    case OptionMenuForPLibData.ZoneType.Sandstone:
                        return SubWorld.ZoneType.Sandstone;
                    case OptionMenuForPLibData.ZoneType.ToxicJungle:
                        return SubWorld.ZoneType.ToxicJungle;
                    case OptionMenuForPLibData.ZoneType.MagmaCore:
                        return SubWorld.ZoneType.MagmaCore;
                    case OptionMenuForPLibData.ZoneType.OilField:
                        return SubWorld.ZoneType.OilField;
                    case OptionMenuForPLibData.ZoneType.Space:
                        return SubWorld.ZoneType.Space;
                    case OptionMenuForPLibData.ZoneType.Ocean:
                        return SubWorld.ZoneType.Ocean;
                    case OptionMenuForPLibData.ZoneType.Rust:
                        return SubWorld.ZoneType.Rust;
                    case OptionMenuForPLibData.ZoneType.Forest:
                        return SubWorld.ZoneType.Forest;
                    case OptionMenuForPLibData.ZoneType.Radioactive:
                        return SubWorld.ZoneType.Radioactive;
                    case OptionMenuForPLibData.ZoneType.Swamp:
                        return SubWorld.ZoneType.Swamp;
                    case OptionMenuForPLibData.ZoneType.Wasteland:
                        return SubWorld.ZoneType.Wasteland;
                    case OptionMenuForPLibData.ZoneType.RocketInterior:
                        return SubWorld.ZoneType.RocketInterior;
                    case OptionMenuForPLibData.ZoneType.Metallic:
                        return SubWorld.ZoneType.Metallic;
                    case OptionMenuForPLibData.ZoneType.Barren:
                        return SubWorld.ZoneType.Barren;
                    case OptionMenuForPLibData.ZoneType.Moo:
                        return SubWorld.ZoneType.Moo;
                    default:
                        return SubWorld.ZoneType.RocketInterior;
                }
            }

        }
    }
}
