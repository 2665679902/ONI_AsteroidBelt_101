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
    internal class LittleMiscBiome: BiomeSetter
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
            return "expansion1::subworlds/moo/MooCore";
        }

        protected override int GetdefaultTemperature()
        {
            return -1;
        }

        protected override Band[] GetBands()
        {
            return new Band[]
            {
                new Band(0.2, SimHashes.IgneousRock),
                new Band(0.2, SimHashes.MaficRock),
                new Band(0.2, SimHashes.Regolith),
                new Band(0.2, SimHashes.MaficRock),
                new Band(0.2, SimHashes.MaficRock),
                new Band(0.2, SimHashes.Regolith),
                new Band(0.2, SimHashes.MaficRock),
                new Band(0.2, SimHashes.IronOre),
                new Band(0.2, SimHashes.IgneousRock),
                new Band(0.2, SimHashes.Cuprite),
                new Band(0.2, SimHashes.Regolith),
                new Band(0.2, SimHashes.Rust)
            };//泥土 火成岩 金矿 铝矿 铜矿 碳 
        }

        protected override List<Critter> GetSpawnablesOnFloor()
        {
            return new List<Critter>();
        }

        protected override List<Critter> GetSpawnablesInGround()
        {
            return new List<Critter>{
                new Critter("MOLE",0.0002) ,//田鼠
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
