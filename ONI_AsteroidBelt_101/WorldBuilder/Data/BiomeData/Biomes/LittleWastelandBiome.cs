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
    internal class LittleWastelandBiome: BiomeSetter
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
            return "expansion1::subworlds/wasteland/WastelandWorm";
        }

        protected override int GetdefaultTemperature()
        {
            return 320;
        }

        protected override Band[] GetBands()
        {
            return new Band[]
            {
                new Band(0.2, SimHashes.SandStone),
                new Band(0.2, SimHashes.IgneousRock),
                new Band(0.2, SimHashes.MaficRock),
                new Band(0.2, SimHashes.Cuprite),
                new Band(0.2, SimHashes.IgneousRock),
                new Band(0.2, SimHashes.MaficRock),
                new Band(0.2, SimHashes.Oxygen),
                new Band(0.2, SimHashes.MaficRock),
                new Band(0.2, SimHashes.Oxygen),
                new Band(0.2, SimHashes.MaficRock),
                new Band(0.2, SimHashes.Sulfur),
                new Band(0.2, SimHashes.Oxygen)
            };//砂石 火成岩 硫 痒 铜矿 镁铁质岩
        }

        protected override List<Critter> GetSpawnablesOnFloor()
        {
            return new List<Critter>{
                new Critter("Cylindrica",0.0001) ,//极乐刺
                new Critter("DivergentBeetle",0.0001) ,//甲虫
                new Critter("WormPlant",0.0003) ,//虫果
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
