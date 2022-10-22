using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarApps.Models
{
    public class CarsModel
    {
        public string CarNumberPlateName { get; set; }
        public bool Autopilot { get; set; }
        public bool ExteriorPaint { get; set; }
        public bool InteriorColor { get; set; }
        public float BasePrice { get; set; } = 100000;
    }
}
