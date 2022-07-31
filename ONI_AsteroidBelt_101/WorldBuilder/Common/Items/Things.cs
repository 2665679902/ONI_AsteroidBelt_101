using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateClasses;

namespace ONI_AsteroidBelt_101.WorldBuilder.Common.Items
{
    internal class Things
    {
        public Things(string name, int amount)
        {
            Name = name;
            Amount = amount;
        }

        public Things()
        {

        }

        public string Name { get; set; } = "";

        public int Amount { get; set; } = 1;

        public Prefab GetPrefab(int x, int y)
        {
            return new Prefab(Name, Prefab.Type.Pickupable, x, y, 0, _units: Amount);
        }
    }
}
