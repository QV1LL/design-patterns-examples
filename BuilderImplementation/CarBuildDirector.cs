using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderImplementation
{
    internal class CarBuildDirector
    {
        private ICarBuilder _builder;

        public CarBuildDirector(ICarBuilder builder)
        {
            _builder = builder;
        }

        public void BuildSuperCar()
        {
            this._builder.SetGearboxType(GearboxType.DUAL_CLUTCH);
            this._builder.SetPower(600);
            this._builder.SetEngineVolume(6.0f);
            this._builder.SetTyreTypes(TyreTypes.SLIC);
        }

        public void BuildOffroadCar()
        {
            this._builder.SetGearboxType(GearboxType.MANUAL);
            this._builder.SetPower(300);
            this._builder.SetTyreTypes(TyreTypes.OFFROAD);
        }

        public void BuildCasualCar()
        {
            this._builder.SetGearboxType(GearboxType.AUTOMATIC);
            this._builder.SetPower(180);
            this._builder.SetTyreTypes(TyreTypes.CASUAL);
        }
    }
}
