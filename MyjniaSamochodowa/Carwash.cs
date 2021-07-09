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

        //add timespan here and 
        public string CarDrivesUp(int ID, string Brand, string Color)
        {
            return TS + " "+ID + ". A " + Color + " " + Brand + " Drives up to the carwash number....";
        }
        public string Washing(int ClientID, int StationID, string Brand, string Color, TimeSpan TS)
        {
            return TS+" Client: " + ClientID + " in their " + Color + " " + Brand + " is washing his car at station " + StationID;
        }
        //here
        public string CarDrivesAway(int ID, string Brand, string Color)
        {
            
            return TS + " " + ID + ". A " + Color + " " + Brand + " Drives away from the carwash number....";
        }
        public TimeSpan Add(TimeSpan TS, TimeSpan WashinDrivinEtc)
        {
            TimeSpan xD = TS + WashinDrivinEtc;
            return xD;
        }

        private TimeSpan TS = new TimeSpan(0,0,0);
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
        public TimeSpan GetTS()
        {
            return this.TS;
        }
        public void SetTS(TimeSpan TS)
        {
            this.TS = TS;
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
