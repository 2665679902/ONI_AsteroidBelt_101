using Klei.CustomSettings;
using static ONI_AsteroidBelt_101.Common.Configs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ONI_AsteroidBelt_101.WorldBuilder.Common.WorldDiscribe;
using ONI_AsteroidBelt_101.WorldBuilder.Data.ClusterData;
using ONI_AsteroidBelt_101.Loger;

namespace ONI_AsteroidBelt_101.WorldBuilder
{
    internal static class ConfigData
    {
        public static bool IsAsteroidBelt
        {
            get
            {
                return CustomGameSettings.Instance.GetCurrentQualitySetting(CustomGameSettingConfigs.ClusterLayout).id == ("clusters/" + ClusterName);
            }
        }

        public static BaseCluster CurrentCluster { get => DefaultCluster.Cluster(); }

        public static double ResourceModifier { get; set; } = 1;

        public static double TempretureModifier { get; set; } = 1;
    }
}
