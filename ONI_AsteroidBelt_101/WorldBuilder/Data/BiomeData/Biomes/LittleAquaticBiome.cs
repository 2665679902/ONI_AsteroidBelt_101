using ONI_AsteroidBelt_101.WorldBuilder.Common.Biome;
using ONI_AsteroidBelt_101.WorldBuilder.Common.BiomeDiscribe;
using ONI_AsteroidBelt_101.WorldBuilder.Common.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONI_AsteroidBelt_101.WorldBuilder.Data.BiomeData.Biomes
{
    internal class LittleAquaticBiome : BiomeSetter
    {
        

        protected override CommonBiomeData GetDefaultBiomeData()
        {
            return new CommonBiomeData()
            {
                BiomeType = Biome,
                BehaviorPattern = BiomeBehaviorPattern.Punctate,
                LocationPattern = BiomeLocationPattern.Middle,
            };
        }

        protected override string GetbackgroundSubworld()
        {
            return "expansion1::subworlds/ocean/med_OceanDeep";
        }

        protected override int GetdefaultTemperature()
        {
            return -1;
        }

        protected override Band[] GetBands()
        {
            return new Band[]
            {
                new Band(0.2, SimHashes.Water),
                new Band(0.2, SimHashes.Graphite),
                new Band(0.2, SimHashes.Water),
                new Band(0.2, SimHashes.Oxygen),
                new Band(0.2, SimHashes.Water),
                new Band(0.2, SimHashes.IgneousRock),
                new Band(0.2, SimHashes.Water),
                new Band(0.2, SimHashes.Water),
                new Band(0.2, SimHashes.Water),
                new Band(0.2, SimHashes.IgneousRock),
                new Band(0.2, SimHashes.Graphite),
                new Band(0.2, SimHashes.CarbonDioxide)
            };// 水 石墨
        }

        protected override List<Critter> GetSpawnablesOnFloor()
        {
            return new List<Critter>();
        }

        protected override List<Critter> GetSpawnablesInGround()
        {
            return new List<Critter>();
        }

        protected override List<Critter> GetSpawnablesInLiquid()
        {
            return new List<Critter>
            {
                new Critter("Pacu",0.0001) ,//帕库鱼
            };
        }

        protected override List<Critter> GetSpawnablesOnCeil()
        {
            return new List<Critter>();
        }

        protected override List<Critter> GetSpawnablesInAir()
        {
            return new List<Critter>();
        }
    }
}
