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
        private int _power;
        private int _weight;
        private float _engineVolume;

        private GearboxType _gearType;
        private TyreTypes _tyreType;

        public Car(int power, int weight, float engineVolume, GearboxType gearType, TyreTypes tyreType)
        {
            this._power = power;
            this._weight = weight;
            this._engineVolume = engineVolume;
            this._gearType = gearType;
            this._tyreType = tyreType;
        }

        public void PrintStataments()
        {
            Console.WriteLine("Power: " + this._power + "\n"
                + "Weight: " + this._weight + "\n"
                + "EngineVolume: " + this._engineVolume + "\n"
                + "Gearbox type: " + this._gearType + "\n"
                + "Tyre type: " + this._tyreType + "\n");
        }
    }
}
