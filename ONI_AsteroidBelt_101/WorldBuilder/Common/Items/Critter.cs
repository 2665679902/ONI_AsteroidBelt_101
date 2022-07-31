using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateClasses;

namespace ONI_AsteroidBelt_101.WorldBuilder.Common.Items
{
    internal class Critter
    {
        public Critter(string name, double possibility)
        {
            Name = name;
            Possibility = possibility;
        }
        public Critter()
        {

        }
        public string Name { get; set; } = "";

        public double Possibility { get; set; } = 0.0000001;

        public virtual Prefab GetPrefab(int x, int y)
        {
            return new Prefab(Name, Prefab.Type.Pickupable, x, y, 0);
        }
    }
}
