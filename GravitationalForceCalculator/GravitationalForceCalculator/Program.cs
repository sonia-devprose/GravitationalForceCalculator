using System;
using System.IO;

namespace GravitationalForceCalculator
{

     class Program
        {

        static void Main(string[] args) 
        {


            // Gravitational constant: 6.67430 × 10^−11 N⋅(m/kg)^2

            double gravitationalConstant = 6.67430e-11;
            Console.WriteLine("Gravitational constant: " + gravitationalConstant);

            // Mass of Earth (kg)

            double massEarth = 5972000000;
            Console.WriteLine("Mass of the earth: " + massEarth);


            // Mass of the ISS (kg)

            float massISS = 42000f;
            Console.WriteLine("Mass of the ISS: " + massISS);

            // Distance from Earth's center to ISS (m) [Earth's radius +ISS altitude]

            double distanceISS = 6371000 + 408000; // earth's radius plus ISS altitude
            Console.WriteLine("Distance from earth's center to ISS: " + distanceISS);

            // Calculating gravitational force between Earth and ISS

            double gravitational_force = (gravitationalConstant * massEarth * massISS) / (distanceISS * distanceISS);
            Console.WriteLine("Gravitational force: " + gravitational_force + " N");

        }


    }


}