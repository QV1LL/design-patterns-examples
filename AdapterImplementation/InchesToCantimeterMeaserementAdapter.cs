using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterImplementation
{
    internal class InchesToCantimeterMeaserementAdapter : Measurement
    {
        private InchesMeasurement measurement;

        public InchesToCantimeterMeaserementAdapter(InchesMeasurement inchesMeasurement) { 
            this.measurement = inchesMeasurement;
        }    

        public float GetValue()
        {
            return this.measurement.GetValue() * 2.54f;
        }
    }
}
