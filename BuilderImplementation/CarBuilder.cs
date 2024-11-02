using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderImplementation
{
    internal class CarBuilder : ICarBuilder
    {
        private Car _product;

        public CarBuilder ()
        {
            _product = new Car();
        }

        public Car Create()
        {
            Car buildedCar = this._product;

            this.Reset();

            return buildedCar;
        }

        private void Reset()
        {
            this._product = new Car();
        }

        public void SetPower(int power)
        {
            this._product.Power = power;
        }

        public void SetWeight(int weight)
        {
            this._product.Weight = weight;
        }

        public void SetEngineVolume(float engineVolume)
        {
            this._product.EngineVolume = engineVolume;
        }

        public void SetGearboxType(GearboxType gearboxType)
        {
            this._product.GearType = gearboxType;
        }

        public void SetTyreTypes(TyreTypes tyreTypes)
        {
            this._product.TyreType = tyreTypes;
        }
    }
}
