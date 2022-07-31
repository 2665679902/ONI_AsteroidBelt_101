using Newtonsoft.Json;
using ONI_AsteroidBelt_101.Loger;
using PeterHan.PLib.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ONI_AsteroidBelt_101.UI.OptionMenuForPLibData;

namespace ONI_AsteroidBelt_101.UI
{
    [ModInfo("", "", true)]
    [ConfigFile("config.json", true, false)]
    internal class OptionMenuForPLib
    {
        public static OptionMenuForPLib Instance { get; private set; } = new OptionMenuForPLib();

        [Option("Width", " It will be laggy if habitat is too big", "SpaceShip")]
        [JsonProperty]
        [Limit(20, 100)]
        public int SpaceShipWidth { get; set; } = 20;

        [Option("Hight", " It will be laggy if habitat is too big", "SpaceShip")]
        [JsonProperty]
        [Limit(20, 100)]
        public int SpaceShipHight { get; set; } = 20;

        [Option("Background", "Get boring with the defult background?", "SpaceShip")]
        [JsonProperty]
        public ZoneType InteriorzoneType { get; set; } = ZoneType.RocketInterior;


        [JsonIgnore]
        [Option("A button", "That's All", null)]
        public Action<object> CommonCarePackage
        {
            get
            {
                return new Action<object>((o) => Log.Debug("Button Clicked"));
            }
        }














        public static void Reload()
        {
            Instance = POptions.ReadSettings<OptionMenuForPLib>() ?? new OptionMenuForPLib();
        }

    }



    internal static class OptionMenuForPLibData
    {
        public enum ZoneType
        {
            FrozenWastes,
            CrystalCaverns,
            BoggyMarsh,
            Sandstone,
            ToxicJungle,
            MagmaCore,
            OilField,
            Space,
            Ocean,
            Rust,
            Forest,
            Radioactive,
            Swamp,
            Wasteland,
            RocketInterior,
            Metallic,
            Barren,
            Moo
        }

    }

}
