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
    internal class LittleOilBiome : BiomeSetter
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
            return "expansion1::subworlds/oil/OilSparse";
        }

        protected override int GetdefaultTemperature()
        {
            return 340;
        }

        protected override Band[] GetBands()
        {
            return new Band[]
            {
                new Band(0.2, SimHashes.Diamond),
                new Band(0.2, SimHashes.IgneousRock),
                new Band(0.2, SimHashes.Fossil),
                new Band(0.2, SimHashes.IgneousRock),
                new Band(0.2, SimHashes.CrudeOil),
                new Band(0.2, SimHashes.SourGas),
                new Band(0.2, SimHashes.CrudeOil),
                new Band(0.2, SimHashes.IgneousRock),
                new Band(0.2, SimHashes.IgneousRock),
                new Band(0.2, SimHashes.CrudeOil),
                new Band(0.2, SimHashes.SourGas),
                new Band(0.2, SimHashes.Fossil),
                new Band(0.2, SimHashes.IronOre),
                new Band(0.2, SimHashes.IronOre),
                new Band(0.2, SimHashes.IgneousRock),
                new Band(0.2, SimHashes.CrudeOil),
                new Band(0.2, SimHashes.Lead),
                new Band(0.2, SimHashes.Diamond)
            };//  钻石 原油 铅 
        }

        protected override List<Critter> GetSpawnablesOnFloor()
        {
            return new List<Critter>
            {
                new Critter("EVILFLOWER",0.0001) ,//花
                new Critter("OilFloaterDecor", 0.0001) ,//浮油生物

            };
        }

        protected override List<Critter> GetSpawnablesInGround()
        {
            return new List<Critter>
            {
               new Critter("CactusPlantSeed",0.01) ,//雀跃掌

            };
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
