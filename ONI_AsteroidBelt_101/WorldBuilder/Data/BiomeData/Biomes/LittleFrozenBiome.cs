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
    internal class LittleFrozenBiome : BiomeSetter
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
            return "subworlds/barren/BarrenGranite";
        }

        protected override int GetdefaultTemperature()
        {
            return 42;
        }

        protected override Band[] GetBands()
        {
            return new Band[]
            {
                new Band(0.2, SimHashes.LiquidOxygen),
                new Band(0.2, SimHashes.Ice),
                new Band(0.2, SimHashes.SolidCarbonDioxide),
                new Band(0.2, SimHashes.LiquidOxygen),
                new Band(0.2, SimHashes.BrineIce),
                new Band(0.2, SimHashes.SedimentaryRock),
                new Band(0.2, SimHashes.SedimentaryRock),
                new Band(0.2, SimHashes.LiquidOxygen),
                new Band(0.2, SimHashes.SedimentaryRock),
                new Band(0.2, SimHashes.LiquidOxygen),
                new Band(0.2, SimHashes.BrineIce),
                new Band(0.2, SimHashes.SedimentaryRock)
            };//固液态co2 冰 液氧 浓盐冰 雪 污染冰
        }

        protected override List<Critter> GetSpawnablesOnFloor()
        {
            return new List<Critter>
            {
                new Critter("ColdWheat",0.0001) ,//冰霜麦粒 
                new Critter("ColdBreather",0.01) ,//冰萝卜

            };
        }

        protected override List<Critter> GetSpawnablesInGround()
        {
            return new List<Critter>
            {
                new Critter("ColdBreatherSeed",0.01) ,//冰萝卜
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
