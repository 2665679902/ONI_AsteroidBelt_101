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
    internal class LittleHotMarshBiome: BiomeSetter
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
            return "subworlds/marsh/HotMarsh";
        }

        protected override int GetdefaultTemperature()
        {
            return 310;
        }

        protected override Band[] GetBands()
        {
            return new Band[]
            {
                new Band(0.2, SimHashes.Algae),
                new Band(0.2, SimHashes.Clay),
                new Band(0.2, SimHashes.SlimeMold,disease: Band.DiseaseID.SlimeGerms),
                new Band(0.2, SimHashes.CarbonDioxide),
                new Band(0.2, SimHashes.SedimentaryRock),
                new Band(0.2, SimHashes.SedimentaryRock),
                new Band(0.2, SimHashes.Algae),
                new Band(0.2, SimHashes.SlimeMold),
                new Band(0.2, SimHashes.Clay),
                new Band(0.2, SimHashes.CarbonDioxide),
                new Band(0.2, SimHashes.GoldAmalgam),
                new Band(0.2, SimHashes.CarbonDioxide),
                new Band(0.2, SimHashes.GoldAmalgam),
            };//藻类 粘菌 沉积岩 金 受污染的氧气 co2
        }

        protected override List<Critter> GetSpawnablesOnFloor()
        {
            return new List<Critter>{
                new Critter("BulbPlant",0.01) ,//同伴芽
            };
        }

        protected override List<Critter> GetSpawnablesInGround()
        {
            return new List<Critter>{
                new Critter("BulbPlantSeed",0.01) ,//同伴芽
                new Critter("BasicFabricMaterialPlantSeed",0.0001) ,//同伴芽
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
            return new List<Critter>{
                new Critter("Puft",0.0001) ,//喷浮飞鱼
            };
        }
    }
}

