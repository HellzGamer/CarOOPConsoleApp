using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp.Data
{
    public class Car : Vehicle
    {
        public Car()
        {

        }

        public Car(string name, int age, double priceofpurchase, double mileage, bool involvedinaccident) : base(name, age, priceofpurchase, mileage, involvedinaccident)
        {
            this.Name = name;
            this.Age = age;
            this.PriceOfPurchase = priceofpurchase;
            this.Mileage = mileage;
            this.InvolvedInAccident = involvedinaccident;
        }

        public override double GetCurrentValue()
        {
            double value = PriceOfPurchase;

            if (Age <= 5)
            {
                value -= 8000;
            }
            else
                if (Age > 5 && Age <= 10)
            {
                value -= 10000;
            }
            else
                if (Age > 10)
            {
                value -= 15000;
            }

            if (Mileage <= 50000)
            {
                value -= (value * 0.05);
            }
            else
                if (Mileage > 50000 && Mileage <= 100000)
            {
                value -= (value * 0.10);
            }
            else
                if (Mileage > 100000)
            {
                value -= (value * 0.30);
            }

            switch (InvolvedInAccident)
            {
                case true:
                    value -= 10000;
                    break;
            }
            return value;
        }
    }
}
