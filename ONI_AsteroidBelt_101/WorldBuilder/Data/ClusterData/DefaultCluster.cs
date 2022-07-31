using ONI_AsteroidBelt_101.WorldBuilder.Common.WorldDiscribe;
using static ONI_AsteroidBelt_101.Common.Configs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ONI_AsteroidBelt_101.WorldBuilder.Data.WorldData.Worlds;

namespace ONI_AsteroidBelt_101.WorldBuilder.Data.ClusterData
{
    internal class DefaultCluster
    {
        public static BaseCluster Cluster()
        {
            var res = new BaseCluster()
            {
                Name = ClusterName,
                Description = ClusterDescription,
                CoordinatePrefix = "AB-C",
                MenuOrder = 10,
                ClusterCategory = 2,
                Difficulty = 5,
                StartWorldIndex = 0,
                NumRings = 12,
                StartWorld = new List<BaseWorldData> { new AsteroidBeltSandStoneStart().DefaultWorldData },
                InnerCluster = new List<BaseWorldData>
                {
                    new AsteroidBeltLittleForest().DefaultWorldData,
                    new AsteroidBeltLittleOil().DefaultWorldData,
                    new AsteroidBeltLittleJungle().DefaultWorldData,
                    new AsteroidBeltLittleSwamp().DefaultWorldData,
                },
                OuterWorlds = new List<BaseWorldData>
                {
                    new AsteroidBeltLittleOcean().DefaultWorldData,
                    new AsteroidBeltLittleRust().DefaultWorldData,
                    new AsteroidBeltLittleWasteland().DefaultWorldData,
                    new AsteroidBeltLittleRadioactive().DefaultWorldData,
                    new AsteroidBeltLittleMagma().DefaultWorldData,
                    new AsteroidBeltLittleHotMarsh().DefaultWorldData,
                },
                PoiPlacements = new List<BasepoiData>
                {
                    HarvestablePOIs(),
                    HarvestableSpacePOI_SandyOreField(),
                    HarvestableSpacePOI_OrganicMassField(),
                    HarvestableSpacePOI_GildedAsteroidField(),
                    HarvestableSpacePOI_RadioactiveGasCloud(),
                    HarvestableSpacePOI_RockyAsteroidField(),
                    HarvestableSpacePOI_CarbonAsteroidField(),
                    ArtifactSpacePOI_GravitasSpaceStation1(),
                    ArtifactSpacePOI_RussellsTeapot(),
                    ArtifactSpacePOI_GravitasSpaceStation2()
                }
            };

            return res;
        }

        private static BasepoiData HarvestablePOIs()
        {
            var res = new BasepoiData()
            {
                Data = new List<string> { "TemporalTear" },
                NumToSpawn = 1,
                AvoidClumping = false,
                AllowedRingsMax = 10,
                AllowedRingsMin = 8,
                CanSpawnDuplicates = null
            };
            return res;
        }

        private static BasepoiData HarvestableSpacePOI_SandyOreField()
        {
            var res = new BasepoiData()
            {
                Data = new List<string> { "HarvestableSpacePOI_SandyOreField" },
                NumToSpawn = 1,
                AvoidClumping = null,
                AllowedRingsMax = 3,
                AllowedRingsMin = 2,
                CanSpawnDuplicates = null
            };
            return res;
        }

        private static BasepoiData HarvestableSpacePOI_OrganicMassField()
        {
            var res = new BasepoiData()
            {
                Data = new List<string> { "HarvestableSpacePOI_OrganicMassField" },
                NumToSpawn = 1,
                AvoidClumping = null,
                AllowedRingsMax = 7,
                AllowedRingsMin = 5,
                CanSpawnDuplicates = null
            };
            return res;
        }

        private static BasepoiData HarvestableSpacePOI_GildedAsteroidField()
        {
            var res = new BasepoiData()
            {
                Data = new List<string> 
                { 
                    "HarvestableSpacePOI_GildedAsteroidField" ,
                    "HarvestableSpacePOI_GlimmeringAsteroidField",
                    "HarvestableSpacePOI_HeliumCloud",
                    "HarvestableSpacePOI_OilyAsteroidField",
                    "HarvestableSpacePOI_FrozenOreField"
                },
                NumToSpawn = 5,
                AvoidClumping = null,
                AllowedRingsMax = 11,
                AllowedRingsMin = 8,
                CanSpawnDuplicates = null
            };
            return res;
        }


        private static BasepoiData HarvestableSpacePOI_RadioactiveGasCloud()
        {
            var res = new BasepoiData()
            {
                Data = new List<string> { "HarvestableSpacePOI_RadioactiveGasCloud", "HarvestableSpacePOI_RadioactiveAsteroidField" },
                NumToSpawn = 2,
                AvoidClumping = true,
                AllowedRingsMax = 11,
                AllowedRingsMin = 10,
                CanSpawnDuplicates = null
            };
            return res;
        }


        private static BasepoiData HarvestableSpacePOI_RockyAsteroidField()
        {
            var res = new BasepoiData()
            {
                Data = new List<string>
                {
                    "HarvestableSpacePOI_RockyAsteroidField" ,
                    "HarvestableSpacePOI_InterstellarIceField",
                    "HarvestableSpacePOI_InterstellarOcean",
                    "HarvestableSpacePOI_ForestyOreField",
                    "HarvestableSpacePOI_SwampyOreField",
                    "HarvestableSpacePOI_OrganicMassField"
                },
                NumToSpawn = 5,
                AvoidClumping = null,
                AllowedRingsMax = 7,
                AllowedRingsMin = 5,
                CanSpawnDuplicates = true
            };
            return res;
        }


        private static BasepoiData HarvestableSpacePOI_CarbonAsteroidField()
        {
            var res = new BasepoiData()
            {
                Data = new List<string>
                {
                    "HarvestableSpacePOI_CarbonAsteroidField" ,
                    "HarvestableSpacePOI_MetallicAsteroidField",
                    "HarvestableSpacePOI_SatelliteField",
                    "HarvestableSpacePOI_IceAsteroidField",
                    "HarvestableSpacePOI_GasGiantCloud",
                    "HarvestableSpacePOI_ChlorineCloud",
                    "HarvestableSpacePOI_OxidizedAsteroidField",
                    "HarvestableSpacePOI_SaltyAsteroidField",
                    "HarvestableSpacePOI_OxygenRichAsteroidField",
                    "HarvestableSpacePOI_GildedAsteroidField",
                    "HarvestableSpacePOI_GlimmeringAsteroidField",
                    "HarvestableSpacePOI_HeliumCloud",
                    "HarvestableSpacePOI_OilyAsteroidField",
                    "HarvestableSpacePOI_FrozenOreField",
                    "HarvestableSpacePOI_RadioactiveGasCloud",
                    "HarvestableSpacePOI_RadioactiveAsteroidField",
                },
                NumToSpawn = 10,
                AvoidClumping = null,
                AllowedRingsMax = 11,
                AllowedRingsMin = 7,
                CanSpawnDuplicates = true
            };
            return res;
        }

        private static BasepoiData ArtifactSpacePOI_GravitasSpaceStation1()
        {
            var res = new BasepoiData()
            {
                Data = new List<string>
                {
                    "ArtifactSpacePOI_GravitasSpaceStation1" ,
                    "ArtifactSpacePOI_GravitasSpaceStation4",
                    "ArtifactSpacePOI_GravitasSpaceStation6",
                },
                NumToSpawn = 1,
                AvoidClumping = true,
                AllowedRingsMax = 3,
                AllowedRingsMin = 2,
                CanSpawnDuplicates = null
            };
            return res;
        }

        private static BasepoiData ArtifactSpacePOI_RussellsTeapot()
        {
            var res = new BasepoiData()
            {
                Data = new List<string>
                {
                    "ArtifactSpacePOI_RussellsTeapot" 
                },
                NumToSpawn = 1,
                AvoidClumping = true,
                AllowedRingsMax = 11,
                AllowedRingsMin = 9,
                CanSpawnDuplicates = null
            };
            return res;
        }

        private static BasepoiData ArtifactSpacePOI_GravitasSpaceStation2()
        {
            var res = new BasepoiData()
            {
                Data = new List<string>
                {
                    "ArtifactSpacePOI_GravitasSpaceStation2" ,
                    "ArtifactSpacePOI_GravitasSpaceStation3",
                    "ArtifactSpacePOI_GravitasSpaceStation5",
                    "ArtifactSpacePOI_GravitasSpaceStation7",
                    "ArtifactSpacePOI_GravitasSpaceStation8"

                },
                NumToSpawn = 4,
                AvoidClumping = true,
                AllowedRingsMax = 11,
                AllowedRingsMin = 4,
                CanSpawnDuplicates = null
            };
            return res;
        }


    }


}
