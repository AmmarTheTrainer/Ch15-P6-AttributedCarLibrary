using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch15_P6_AttributedCarLibrary
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct , Inherited = false)]
    // A custom Attribute
    public sealed class VehicleDescriptionAttribute : System.Attribute
    {
        public string Description { get; set; }

        public VehicleDescriptionAttribute(string vehicalDescription)
        {
            Description = vehicalDescription;
        }
        public VehicleDescriptionAttribute()
        {

        }
    }
    
}
