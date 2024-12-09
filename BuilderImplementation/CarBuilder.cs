using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderImplementation
{
    internal class CarBuilder : ICarBuilder
    {
        private int _power = 100;
        private int _weight = 1000;
        private float _engineVolume = 1.4f;

        private GearboxType _gearType = GearboxType.MANUAL;
        private TyreTypes _tyreType = TyreTypes.CASUAL;

        public CarBuilder ()
        {

        }

        public Car Create()
        {
            return new Car(this._power,
                this._weight,
                this._engineVolume,
                this._gearType,
                this._tyreType);
        }

        public void SetPower(int power)
        {
            this._power = power;
        }

        public void SetWeight(int weight)
        {
            this._weight = weight;
        }

        public void SetEngineVolume(float engineVolume)
        {
            this._engineVolume = engineVolume;
        }

        public void SetGearboxType(GearboxType gearboxType)
        {
            this._gearType = gearboxType;
        }

        public void SetTyreTypes(TyreTypes tyreTypes)
        {
            this._tyreType = tyreTypes;
        }
    }
}
