using System;
using System.Collections.Generic;
using System.Text;

namespace MyjniaSamochodowa
{
    class Carwash
    {
        public Carwash (int ID, TimeSpan WashingTime)
        {
            SetID(ID);
            SetWashingTime(WashingTime);
        }


        public static void Summary(TimeSpan openingTime, TimeSpan closingTime, int nClients, TimeSpan avgQueueTime)
        {
            Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), "White");
            System.Console.WriteLine("Today we worked from " + openingTime + " till " + closingTime + " and served " + nClients + " clients.");
            System.Console.WriteLine("Average time in queue equals to: " + avgQueueTime);
        }
        
        
        private int ID;
        private TimeSpan WashingTime;
        private bool Occupied = false;

        public bool GetOccupied()
        {
            return this.Occupied;
        }
        public void SetOccupied(bool Occupied)
        {
            this.Occupied = Occupied;
        }
        
        public int GetID()
        {
            return this.ID;
        }
        public TimeSpan GetWashingTime()
        {
            return this.WashingTime;
        }
        public void SetID(int ID)
        {
            this.ID = ID;
        }
        public void SetWashingTime(TimeSpan WashingTime)
        {
            this.WashingTime = WashingTime;
        }
    }
}
