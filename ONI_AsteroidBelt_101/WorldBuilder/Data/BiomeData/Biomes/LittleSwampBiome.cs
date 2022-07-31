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
    internal class LittleSwampBiome: BiomeSetter
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
            return "expansion1::subworlds/swamp/SwampStart";
        }

        protected override int GetdefaultTemperature()
        {
            return -1;
        }

        protected override Band[] GetBands()
        {
            return new Band[]
            {
                new Band(0.2, SimHashes.Cobaltite),
                new Band(0.2, SimHashes.Mud),
                new Band(0.2, SimHashes.DirtyWater),
                new Band(0.2, SimHashes.ToxicSand),
                new Band(0.2, SimHashes.Cobaltite),
                new Band(0.2, SimHashes.Mud),
                new Band(0.2, SimHashes.CarbonDioxide),
                new Band(0.2, SimHashes.DirtyWater),
                new Band(0.2, SimHashes.Mud),
                new Band(0.2, SimHashes.ToxicSand),
                new Band(0.2, SimHashes.CarbonDioxide),
                new Band(0.2, SimHashes.Phosphorite)
            };//污染土 钴矿 泥巴 co2 磷矿
        }

        protected override List<Critter> GetSpawnablesOnFloor()
        {
            return new List<Critter>{
                new Critter("STATERPILLAR",0.0002) ,//蛞蝓
                new Critter("SwampForagePlantPlanted",0.02) ,//甜菜根
                new Critter("WineCups",0.02) ,//飞机杯
            };
        }

        protected override List<Critter> GetSpawnablesInGround()
        {
            return new List<Critter>();
        }

        protected override List<Critter> GetSpawnablesInLiquid()
        {
            return new List<Critter>();
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
