using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterImplementation
{
    internal class InchesMeasurement
    {
        protected float _value;

        public float GetValue()
        {
            return this._value;
        }

        public void SetValue(float value)
        {
            this._value = value;
        }
    }
}
