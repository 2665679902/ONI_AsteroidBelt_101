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
    internal class LittleJungleBiome: BiomeSetter
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
            return "subworlds/jungle/Jungle";
        }

        protected override int GetdefaultTemperature()
        {
            return 320;
        }

        protected override Band[] GetBands()
        {
            return new Band[]
            {
                new Band(0.2, SimHashes.Phosphorite),
                new Band(0.2, SimHashes.Carbon),
                new Band(0.2, SimHashes.IgneousRock),
                new Band(0.2, SimHashes.IronOre),
                new Band(0.2, SimHashes.Algae),
                new Band(0.2, SimHashes.IgneousRock),
                new Band(0.2, SimHashes.ChlorineGas),
                new Band(0.2, SimHashes.IronOre),
                new Band(0.2, SimHashes.Hydrogen),
                new Band(0.2, SimHashes.ChlorineGas),
                new Band(0.2, SimHashes.IgneousRock),
                new Band(0.2, SimHashes.IronOre),
                new Band(0.2, SimHashes.Phosphorite),
            };//磷矿 c 火成岩 Fe 藻类 H 氯
        }

        protected override List<Critter> GetSpawnablesOnFloor()
        {
            return new List<Critter>{
                new Critter("SwampLily",0.0001) ,//芳香百合
                new Critter("Drecko",0.0003) ,//毛鳞壁虎
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
            return new List<Critter>{
                new Critter("SpiceVine",0.0001) ,//火椒藤
            };
        }

        protected override List<Critter> GetSpawnablesInAir()
        {
            return new List<Critter>();
        }
    }
}

