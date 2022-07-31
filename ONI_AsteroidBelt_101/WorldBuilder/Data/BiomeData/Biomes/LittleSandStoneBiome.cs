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
    internal class LittleSandStoneBiome : BiomeSetter
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
            return "subworlds/sandstone/SandstoneStart";
        }

        protected override int GetdefaultTemperature()
        {
            return -1;
        }

        protected override Band[] GetBands()
        {
            return new Band[]
            {
                new Band(0.2, SimHashes.Water, density: 2f),
                new Band(0.2, SimHashes.Water, density: 2f),
                new Band(0.2, SimHashes.Water, density: 2f),
                new Band(0.2, SimHashes.Water, density: 2f),
                new Band(0.2, SimHashes.Oxygen, density: 2f),
                new Band(0.2, SimHashes.Dirt),
                new Band(0.2, SimHashes.Algae, density: 4f,disease:Band.DiseaseID.SlimeGerms),
                new Band(0.2, SimHashes.IronOre),
                new Band(0.2, SimHashes.SandStone),
                new Band(0.2, SimHashes.SandStone),
                new Band(0.2, SimHashes.SandStone),
                new Band(0.2, SimHashes.Carbon),
                new Band(0.2, SimHashes.SandStone),
                new Band(0.2, SimHashes.Fossil),
                new Band(0.2, SimHashes.Granite),
                new Band(0.2, SimHashes.Cuprite),
                new Band(0.2, SimHashes.Dirt),
                new Band(0.2, SimHashes.Oxygen, density: 2f),
                new Band(0.2, SimHashes.CarbonDioxide)
            };// 水 氧气 泥土 菌泥 铁矿 砂石 二氧化碳 沉积岩 化肥 铜矿
        }

        protected override List<Critter> GetSpawnablesOnFloor()
        {
            return new List<Critter>
            {
                new Critter("Squirrel",0.0001) ,//松鼠
                new Critter("BasicSingleHarvestPlant", 0.03) ,//米虱木
                new Critter("PrickleFlower",0.02 ),//毛刺花
                new Critter("PrickleGrass",0.06) ,//诱人荆棘
                new Critter("BasicForagePlantPlanted",0.05)//淤泥根

            };//松鼠 米虱木 诱人荆棘 毛刺花  淤泥根
        }

        protected override List<Critter> GetSpawnablesInGround()
        {
            return new List<Critter>
            {
                new Critter("Hatch",0.0001) ,//哈奇
                new Critter("BasicForagePlant", 0.003),//淤泥根
                new Critter("BasicSingleHarvestPlantSeed",0.002),//米虱木种子
                new Critter("PrickleFlowerSeed", 0.006) ,//毛刺花种子
                new Critter("ColdBreatherSeed",0.005)//冰息萝卜

            };// 哈奇 淤泥根 米虱木种子 毛刺花种子 冰息萝卜
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
            return new List<Critter>
            {
               new Critter("LightBug",0.0005),//发光虫
            };//发光虫
        }


    }
}
