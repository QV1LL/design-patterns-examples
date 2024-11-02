using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderImplementation
{
    internal interface ICarBuilder
    {
        Car Create();

        public void SetPower(int power);

        public void SetWeight(int weight);

        public void SetEngineVolume(float engineVolume);

        public void SetGearboxType(GearboxType gearboxType);
        public void SetTyreTypes(TyreTypes tyreTypes);
    }
}
