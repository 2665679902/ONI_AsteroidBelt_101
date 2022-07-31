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
    internal abstract class BiomeSetter
    {

        public CommonBiome Biome { get { return GetCommonBiome(); } }

        protected  CommonBiome GetCommonBiome()
        {
            string backgroundSubworld = GetbackgroundSubworld();

            int defaultTemperature = GetdefaultTemperature();

            Band[] bands = GetBands();

            List<Critter> spawnablesInAir = GetSpawnablesInAir();

            List<Critter> spawnablesInGround = GetSpawnablesInGround();

            List<Critter> spawnablesInLiquid = GetSpawnablesInLiquid();

            List<Critter> spawnablesOnCeil = GetSpawnablesOnCeil();

            List<Critter> spawnablesOnFloor = GetSpawnablesOnFloor();

            return new CommonBiome(backgroundSubworld, defaultTemperature, bands, spawnablesOnFloor, spawnablesOnCeil, spawnablesInGround, spawnablesInLiquid, spawnablesInAir);

        }

        public CommonBiomeData DefaultBiomeData { get { return GetDefaultBiomeData(); } }

        protected abstract CommonBiomeData GetDefaultBiomeData();

        protected abstract string GetbackgroundSubworld();

        protected abstract int GetdefaultTemperature();

        protected abstract Band[] GetBands();

        protected abstract List<Critter> GetSpawnablesOnFloor();

        protected abstract List<Critter> GetSpawnablesOnCeil();

        protected abstract List<Critter> GetSpawnablesInGround();

        protected abstract List<Critter> GetSpawnablesInLiquid();

        protected abstract List<Critter> GetSpawnablesInAir();


    }
}
