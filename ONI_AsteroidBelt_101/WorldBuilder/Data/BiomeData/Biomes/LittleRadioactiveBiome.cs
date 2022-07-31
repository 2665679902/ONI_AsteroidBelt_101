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
    internal class LittleRadioactiveBiome: BiomeSetter
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
            return "expansion1::subworlds/radioactive/med_Radioactive";
        }

        protected override int GetdefaultTemperature()
        {
            return 240;
        }

        protected override Band[] GetBands()
        {
            return new Band[]
            {
                new Band(0.2, SimHashes.UraniumOre),
                new Band(0.2, SimHashes.Ice),
                new Band(0.2, SimHashes.Sulfur),
                new Band(0.2, SimHashes.CarbonDioxide),
                new Band(0.2, SimHashes.UraniumOre),
                new Band(0.2, SimHashes.CarbonDioxide),
                new Band(0.2, SimHashes.CarbonDioxide),
                new Band(0.2, SimHashes.Wolframite),
                new Band(0.2, SimHashes.Rust),
                new Band(0.2, SimHashes.CarbonDioxide),
                new Band(0.2, SimHashes.CarbonDioxide),
                new Band(0.2, SimHashes.Ice)
            };//铀矿 冰 硫 铁锈 土 漂白石 co2 黑钨矿
        }

        protected override List<Critter> GetSpawnablesOnFloor()
        {
            return new List<Critter>{
                new Critter("BeeHive",0.002) ,//bee
            };
        }

        protected override List<Critter> GetSpawnablesInGround()
        {
            return new List<Critter>{
                new Critter("CritterTrapPlantSeed",0.02) ,//动物捕草
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
