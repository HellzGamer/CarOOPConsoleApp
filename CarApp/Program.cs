using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarApp.Data;
using CarApp.Logic;

namespace CarApp
{
    class Program
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public static FileLogic fileLogic = new FileLogic();

        static void Main(string[] args)
        {
            int choice = 0;
            string vehicleDetails = "";
            Console.WriteLine("Please select an option");
            Console.WriteLine("1, Write to file");
            Console.WriteLine("2, Read from file");

            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                try
                {
                    var carlogic = new CarLogic();
                    var suv = new SUV
                    {
                        Name = "Nissan Quashqai",
                        Age = 5,
                        PriceOfPurchase = 180000,
                        Mileage = 70000,
                        InvolvedInAccident = true
                    };

                    var van = new Van
                    {
                        Name = "Toyota Hilux",
                        Age = 8,
                        PriceOfPurchase = 200000,
                        Mileage = 160000,
                        InvolvedInAccident = false
                    };

                    var deveshVan = new Van
                    {
                        Name = "Ford Ranger",
                        Age = 2,
                        PriceOfPurchase = 400000,
                        Mileage = 20000,
                        InvolvedInAccident = false
                    };

                    var car = new Car
                    {
                        Name = "Honda Civic",
                        Age = 3,
                        PriceOfPurchase = 250000,
                        Mileage = 30000,
                        InvolvedInAccident = false
                    };

                    carlogic.suvList.Add(suv);
                    carlogic.vanList.Add(van);
                    carlogic.vanList.Add(deveshVan);
                    carlogic.carList.Add(car);

                    vehicleDetails = carlogic.GetVehicleDetails(carlogic.carList, carlogic.vanList, carlogic.suvList);

                    fileLogic.WriteToFile(vehicleDetails);
                    log.Info("Writing to file works");
                    Console.WriteLine(vehicleDetails + Environment.NewLine + "Details Added to TextFile");
                    Console.Read();
                }
                catch (Exception e)
                {
                    log.Error(e.Message + Environment.NewLine + e.StackTrace);
                    Console.WriteLine("Error writing to file " + e.Message);
                    Console.Read();
                }
            }
            else
                if (choice == 2)
            {
                try
                {
                    fileLogic.ReadFromFile();
                    log.Info("Reading from file works");
                }
                catch (Exception e)
                {
                    log.Error(e.Message);
                    Console.WriteLine("Error writing to file " + e.Message);
                    Console.Read();
                }
            }

        }
    }
}
