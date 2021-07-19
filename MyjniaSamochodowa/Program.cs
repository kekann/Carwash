using System;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;

namespace MyjniaSamochodowa
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCarwashes = Input.InputCarwash();
            if (numberOfCarwashes > 100) { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("ARE YOU CRAZY?????"); }

            TimeSpan openingTime = new TimeSpan(0, 0, 0);
            TimeSpan timer = openingTime;
            TimeSpan timerExpire = new TimeSpan(Input.InputTime(), 0, 0);
            TimeSpan oneMinute = new TimeSpan(0, 1, 0);

            int spawnRatio = Input.InputCarSpawnChance();
                
            Queue<Car> cars = new Queue<Car>();
            List<Car> clients = new List<Car>();

            List<Carwash> stations = new List<Carwash>();
            for (int j = 0; j < numberOfCarwashes; j++)
            {
                stations.Add(new Carwash(j, new TimeSpan(0, 5, 0)));
            }
            List<TimeSpan> queueTimes = new List<TimeSpan>();
            Random randomGen = new Random();

            int numberOfClients = 0;
            

            while (timer < timerExpire || cars.Count != 0 || clients.Count!=0)
            {
                //the magical formula
                int ratio = 100;
                ratio = ratio-Math.Max(((cars.Count - 3) * 10), 0);
                //for a driving away car, here I add his queue time to the List and make the Carwash station free
                
                foreach (var client in clients.ToArray())
                {
                    if (client.GetDriveAwayTime() == timer)
                    {
                        stations[client.getCarwashID()].SetOccupied(false);
                        client.Leave(timer);
                        queueTimes.Add(client.GetDriveUpTime() - client.getQueingUpTime());
                        clients.Remove(client);
                    }
                }

                //here car gets added to que  
                int hereWeAddNewCar = randomGen.Next(100);
                if (hereWeAddNewCar < ((spawnRatio*ratio)/100) && timer<timerExpire)
                {
                    int bIndex = randomGen.Next(Car.getBrandsNumber());
                    int cIndex = randomGen.Next(Car.getColorsNumber());
                    //rng care of the cars color and brand.
                    cars.Enqueue(new Car(numberOfClients, bIndex, cIndex));
                    numberOfClients++;
                    cars.Peek().Join(timer);
                }

                //here car goes from queue to washing
                foreach (var station in stations)
                {
                    if (cars.Count != 0)
                    {
                        if (station.GetOccupied() == false)
                            {
                                station.SetOccupied(true);
                                cars.Peek().Washing(cars.Peek().GetClientID(), station.GetID(), cars.Peek().GetBrand(), cars.Peek().GetColor(), timer);
                                cars.Peek().SetDriveAwayTime(timer + station.GetWashingTime());
                                cars.Peek().setCarwashID(station.GetID());
                                clients.Add(cars.Dequeue());
                            }
                    }
                }    
                
                
                timer = timer + oneMinute;
            }
            TimeSpan avg = new TimeSpan(0,1,0);
            foreach (var ts in queueTimes) 
            {
                avg += ts;
            }
            avg = avg / numberOfClients;
            Carwash.Summary(openingTime, timer, numberOfClients, avg);
            Console.ReadLine();
        }
    }
}
