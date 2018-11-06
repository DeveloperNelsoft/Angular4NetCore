using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NelsonCarsalesNetCore.Models
{
    public class Car
    {
        public string networkId { get; set; }
        public string displayTitle { get; set; }
        public string siloTypeFriendlyName { get; set; }
        public string siloTypeColour { get; set; }
        public string displayLocation { get; set; }

    }
}
