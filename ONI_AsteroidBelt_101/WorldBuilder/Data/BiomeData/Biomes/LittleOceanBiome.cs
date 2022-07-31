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
    internal class LittleOceanBiome: BiomeSetter
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
            return -1;
        }

        protected override Band[] GetBands()
        {
            return new Band[]
            {
                new Band(0.2, SimHashes.Granite),
                new Band(0.2, SimHashes.SedimentaryRock),
                new Band(0.2, SimHashes.BleachStone),
                new Band(0.2, SimHashes.Sand),
                new Band(0.2, SimHashes.SaltWater),
                new Band(0.2, SimHashes.SedimentaryRock),
                new Band(0.2, SimHashes.CarbonDioxide),
                new Band(0.2, SimHashes.SedimentaryRock),
                new Band(0.2, SimHashes.Hydrogen),
                new Band(0.2, SimHashes.CarbonDioxide),
                new Band(0.2, SimHashes.Granite),
                new Band(0.2, SimHashes.BleachStone),
                new Band(0.2, SimHashes.Hydrogen),
            };//花岗岩 沉积岩 漂白石 沙子 盐水 H co2
        }

        protected override List<Critter> GetSpawnablesOnFloor()
        {
            return new List<Critter>{
                new Critter("SeaLettuce",0.0001) ,//水草
                new Critter("Crab",0.0001) ,//沙泥蟹
                new Critter("SaltPlant",0.0003) ,//沙盐藤
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

