using System;

namespace AdapterImplementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InchesMeasurement inchesMeasurement = new InchesMeasurement();
            inchesMeasurement.SetValue(10);

            ClientCode(new InchesToCantimeterMeaserementAdapter(inchesMeasurement));
        }

        static void ClientCode(Measurement measurement)
        {
            Console.WriteLine("Measurement: " + measurement.GetValue());
        }
    }
}