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
    internal class LittleForestBiome : BiomeSetter
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
            return "expansion1::subworlds/forest/med_ForestStart";
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
                new Band(0.2, SimHashes.Oxygen, density: 2f),
                new Band(0.2, SimHashes.Dirt),
                new Band(0.2, SimHashes.IgneousRock),
                new Band(0.2, SimHashes.Dirt),
                new Band(0.2, SimHashes.IgneousRock),
                new Band(0.2, SimHashes.Dirt),
                new Band(0.2, SimHashes.SandStone),
                new Band(0.2, SimHashes.Carbon),
                new Band(0.2, SimHashes.IgneousRock),
                new Band(0.2, SimHashes.AluminumOre),
                new Band(0.2, SimHashes.IgneousRock),
                new Band(0.2, SimHashes.Oxygen, density: 2f),
                new Band(0.2, SimHashes.Dirt),
                new Band(0.2, SimHashes.Oxygen, density: 2f),
                new Band(0.2, SimHashes.CarbonDioxide)
            };// 水 氧气 泥土 火成岩 沙子 铝矿 二氧化碳
        }

        protected override List<Critter> GetSpawnablesOnFloor()
        {
            return new List<Critter>
            {
                new Critter("ForestTree",0.0001) ,//树
                new Critter("Oxyfern", 0.025) ,//氧齿蕨
                new Critter("LeafyPlant",0.02 ),//欢乐叶
                new Critter("ForestForagePlantPlanted",0.07) ,//六角根

            };
        }

        protected override List<Critter> GetSpawnablesInGround()
        {
            return new List<Critter>
            {
                new Critter("OxyfernSeed",0.0001) ,//氧齿蕨
                new Critter("LeafyPlantSeed", 0.03),//欢乐叶

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
