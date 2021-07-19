using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace MyjniaSamochodowa
{
    public class Car
    {
        public Car (int ClientID, int brand, int color)
        {
            SetClientID(ClientID);
            SetBrand(carBrands[brand]);
            SetColor(colors[color]);
        }

        public void Join(TimeSpan time)
        {
            Console.WriteLine(time + " " + this.GetColor() + " " + this.GetBrand() + " joined the queque/");
            setQueingUpTime(time);
        }
        public void Leave(TimeSpan time)
        {
            Console.WriteLine(time + " " + this.GetColor() + " " + this.GetBrand() + " is now perfectly clean, and so station "+this.getCarwashID()+" is free now.");
        }
        public void Washing(int ClientID, int StationID, string Brand, string Color, TimeSpan time)
        {
            SetDriveUpTime(time);
            System.Console.WriteLine(time + " Client: " + ClientID + " in their " + Color + " " + Brand + " is washing his car at station " + StationID);
        }

        private static string[] colors = {"Black", "DarkBlue", "DarkGreen", "DarkCyan", "DarkRed", "DarkMagenta", "DarkYellow", "Gray", "DarkGray", "Blue", "Green", "Cyan", "Red", "Magenta", "Yellow", "White", "Black",
                    "DarkBlue", "DarkGreen", "DarkCyan", "DarkRed", "DarkMagenta","DarkYellow", "Gray", "DarkGray", "Blue", "Green","Cyan","Red","Magenta","Yellow", "White"};

        public static int getColorsNumber()
        {
            return colors.Length;
        }
        private static string[] carBrands = { "Audi", "BMW", "Skoda", "Nissan", "Suzuki", "Honda", "Renault", "Mercedes", "Fiat", "Polonez", "Ford", "Ferrari", "Toyota", "Opel" };
        public static int getBrandsNumber()
        {
            return carBrands.Length;
        }

        private int ClientID;
        private string Brand;
        private string Color;
        private TimeSpan DriveUpTime;
        private TimeSpan DriveAwayTime;
        private TimeSpan QueingUpTime;

        

        private int carwashID;
        public void setCarwashID(int carwashID)
        {
            this.carwashID = carwashID;
        }
        public int getCarwashID()
        {
            return this.carwashID;
        }

        public TimeSpan getQueingUpTime()
        {
            return this.QueingUpTime;
        }
        public void setQueingUpTime(TimeSpan queingUpTime)
        {
            this.QueingUpTime = queingUpTime;
        }

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
