using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONI_AsteroidBelt_101.WorldBuilder.Common.Items
{
    internal class Template
    {
        public Template(string name, int min, int max)
        {
            Name = name;
            Min = min;
            Max = max;
        }

        public Template()
        {

        }

        public string Name { get; set; } = "";

        public int Min { get; set; } = 1;

        public int Max { get; set; } = 1;

        public virtual TemplateContainer GetTemplate()
        {
            return TemplateCache.GetTemplate(Name);
        }
    }
}
