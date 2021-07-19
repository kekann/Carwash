using System;
using System.Collections.Generic;
using System.Text;

namespace MyjniaSamochodowa
{
    class Input
    {
        public static int InputCarwash()
        {
            Console.WriteLine("Give me a number of Carwashes in this simulation, please:");
            return Convert.ToInt32(Console.ReadLine());
        }
        public static int InputTime()
        {
            Console.WriteLine("How many hours are we going to be open today?");
            return Convert.ToInt32(Console.ReadLine());
        }
        public static int InputCarSpawnChance()
        {
            Console.WriteLine("Now we only need to know the chance at which a new car can be added to queque every minute (value in %)");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
