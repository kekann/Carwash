using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace MyjniaSamochodowa
{
    public class Car
    {
        public Car (int ClientID, string Brand, string Color, TimeSpan DriveUp, TimeSpan DriveAway)
        {
            SetClientID(ClientID);
            SetBrand(Brand);
            SetColor(Color);
            SetDriveUpTime(DriveUp);
            SetDriveAwayTime(DriveAway);
        }



        private int ClientID;
        private string Brand;
        private string Color;
        private System.TimeSpan DriveUpTime;
        private System.TimeSpan DriveAwayTime;

        public System.TimeSpan GetDriveUpTime()
        {
            return DriveUpTime;
        }
        public void SetDriveUpTime(TimeSpan DriveUpTime)
        {
            this.DriveUpTime = DriveUpTime;
        }

        public System.TimeSpan GetDriveAwayTime()
        {
            return DriveAwayTime;
        }
        public void SetDriveAwayTime(TimeSpan DriveUpTime)
        {
            this.DriveAwayTime = DriveUpTime;
        }
        public string GetColor()
        {
            return this.Color;
        }
        public void SetColor(string Color)
        {
            this.Color = Color;
        }
        public int GetClientID()
        {
            return this.ClientID;
        }
        public void SetClientID(int ID)
        {
            this.ClientID = ID;
        }
        public string GetBrand()
        {
            return this.Brand;
        }
        public void SetBrand(string Brand)
        {
            this.Brand = Brand;
        }
    }
}
