using System;
using System.Drawing;
using System.Collections.Generic;

namespace MyjniaSamochodowa
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumberOfCarwashes = Input.InputCarwash();
            if (NumberOfCarwashes > 100) { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("ARE YOU CRAZY?????"); }
            int NumberOfCars = Input.InputCars();
            
            List<Car> Cars = new List<Car>();
            List<Carwash> Stations = new List<Carwash>();
            
            for(int i = 0; i < NumberOfCars; i++)
            {
                Random randomGen = new Random();
                string[] Colors = {"Black", "DarkBlue", "DarkGreen", "DarkCyan", "DarkRed", "DarkMagenta", "DarkYellow", "Gray", "DarkGray", "Blue", "Green", "Cyan", "Red", "Magenta", "Yellow", "White", "Black",
                    "DarkBlue", "DarkGreen", "DarkCyan", "DarkRed", "DarkMagenta","DarkYellow", "Gray", "DarkGray", "Blue", "Green","Cyan","Red","Magenta","Yellow", "White"};

                string[] CarBrands = { "Audi", "BMW", "Skoda", "Nissan", "Suzuki", "Honda", "Renault", "Mercedes", "Fiat", "Polonez", "Ford", "Ferrari", "Toyota", "Opel" };
                int bIndex = randomGen.Next(CarBrands.Length);
                int cIndex = randomGen.Next(Colors.Length);
                //rng defines how much time the car owner wastes. it also takes care for the cars color and brand.
                Cars.Add(new Car(i, CarBrands[bIndex], Colors[cIndex], new TimeSpan(0, randomGen.Next(0, 2), randomGen.Next(20, 60)), new TimeSpan(0, randomGen.Next(0, 3), randomGen.Next(20, 60))));
            }
            for(int j = 0; j < NumberOfCarwashes; j++)
            {// rng defines how much time it takes for ppl to wash their cars at different stations today ;D
                var rand = new Random();
                Stations.Add(new Carwash(j, new TimeSpan(0,rand.Next(3,10),0)));
            }
            for(int clients = 0; clients < NumberOfCars; clients++)
            {
                for(int stations = 0; stations < NumberOfCarwashes; stations++)
                {
                    if (Stations[stations].GetOccupied() == false)
                    {
                        Stations[stations].SetTS(Stations[stations].Add( Stations[stations].GetTS(), Cars[clients].GetDriveUpTime()));
                        //after adding timespan, continue with this shit xdd
                        Stations[stations].CarDrivesUp()
                    }
                }
            }

        }
    }
}
