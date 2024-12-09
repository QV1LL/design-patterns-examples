using System;

namespace BuilderImplementation
{
    internal class CarBuilderTest
    {
        static void Main(string[] args)
        {
            CarBuilder builder = new CarBuilder();
            CarBuildDirector carBuildDirector = new CarBuildDirector(builder);

            carBuildDirector.BuildOffroadCar();

            Car car = builder.Create();

            car.PrintStataments();
        }
    }
}