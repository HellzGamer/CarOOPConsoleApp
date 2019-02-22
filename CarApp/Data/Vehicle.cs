using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp.Data
{
    public abstract class Vehicle
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double PriceOfPurchase { get; set; }
        public double Mileage { get; set; }
        public bool InvolvedInAccident { get; set; }

        public Vehicle()
        {

        }

        public Vehicle(string name, int age, double priceofpurchase, double mileage, bool involvedinaccident)
        {
            this.Name = name;
            this.Age = age;
            this.PriceOfPurchase = priceofpurchase;
            this.Mileage = mileage;
            this.InvolvedInAccident = involvedinaccident;
        }

        public abstract double GetCurrentValue();
    }
}
