using ONI_AsteroidBelt_101.Loger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TUNING;

namespace ONI_AsteroidBelt_101.Common.CommonData.HabitatConfigs
{
    internal static class HabitatLoad
    {
        public static void Load()
        {
            DataManager.HabitatData.Load();

            Log.Debug($"Set SpaceWith: {HabitatData.SpaceWidth}, {HabitatData.SpaceWidth}");

            ROCKETRY.ROCKET_INTERIOR_SIZE = new Vector2I(HabitatData.SpaceWidth, HabitatData.SpaceWidth);

            FileLoader.WriteIn(@"objects\Habitat", "habitat_huge.yaml",HabitatData.HabitatTample);

            FileLoader.LoadFile(@"objects\Habitat", @"OxygenNotIncluded_Data\StreamingAssets\dlc\expansion1\templates\interiors");

        }

        public static void UnLoad()
        {
            FileLoader.Remove(@"objects\Habitat");
        }
    }
}
