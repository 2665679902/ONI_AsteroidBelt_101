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
    internal class LittleRustBiome: BiomeSetter
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
            return "subworlds/ocean/Ocean";
        }

        protected override int GetdefaultTemperature()
        {
            return 210;
        }

        protected override Band[] GetBands()
        {
            return new Band[]
            {
                new Band(0.2, SimHashes.IronOre),
                new Band(0.2, SimHashes.MaficRock),
                new Band(0.2, SimHashes.Rust),
                new Band(0.2, SimHashes.CarbonDioxide),
                new Band(0.2, SimHashes.ChlorineGas),
                new Band(0.2, SimHashes.Rust),
                new Band(0.2, SimHashes.ChlorineGas),
                new Band(0.2, SimHashes.MaficRock),
                new Band(0.2, SimHashes.Snow),
                new Band(0.2, SimHashes.CarbonDioxide),
                new Band(0.2, SimHashes.MaficRock),
                new Band(0.2, SimHashes.Rust),
                new Band(0.2, SimHashes.IronOre),
            };//铁锈 镁铁质岩 氯 盐水 雪 铁
        }

        protected override List<Critter> GetSpawnablesOnFloor()
        {
            return new List<Critter>{
                new Critter("BeanPlant",0.0001) ,//小吃芽
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

