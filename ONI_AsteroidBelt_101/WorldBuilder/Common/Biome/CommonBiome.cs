using ONI_AsteroidBelt_101.WorldBuilder.Common.BiomeDiscribe;
using ONI_AsteroidBelt_101.WorldBuilder.Common.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONI_AsteroidBelt_101.WorldBuilder.Common.Biome
{
    internal class CommonBiome : BaseBiome
    {
        public CommonBiome(
            string backgroundSubworld, 
            double defaultTemperature, 
            Band[] bands, 
            List<Critter> spawnablesOnFloor, 
            List<Critter> spawnablesOnCeil, 
            List<Critter> spawnablesInGround, 
            List<Critter> spawnablesInLiquid, 
            List<Critter> spawnablesInAir) : 
            base(backgroundSubworld, defaultTemperature, bands, spawnablesOnFloor, spawnablesOnCeil, spawnablesInGround, spawnablesInLiquid, spawnablesInAir)
        {
        }
    }
}
