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
        public static int InputCars()
        {
            Console.WriteLine("Give me a number of Cars in this simulation, please:");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
