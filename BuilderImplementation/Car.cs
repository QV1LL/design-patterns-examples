using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderImplementation
{
    internal enum TyreTypes
    {
        OFFROAD,
        SLIC,
        WINTER,
        CASUAL,
    }

    internal enum GearboxType
    {
        MANUAL,
        AUTOMATIC,
        DUAL_CLUTCH,
    }

    internal class Car
    {
        public int Power;
        public int Weight;
        public float EngineVolume;

        public GearboxType GearType;
        public TyreTypes TyreType;

        public void PrintStataments()
        {
            Console.WriteLine("Power: " + this.Power + "\n"
                + "Weight: " + this.Weight + "\n"
                + "EngineVolume: " + this.EngineVolume + "\n"
                + "Gearbox type: " + this.GearType + "\n"
                + "Tyre type: " + this.TyreType + "\n");
        }
    }
}
