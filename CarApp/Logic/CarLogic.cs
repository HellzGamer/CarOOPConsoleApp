using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarApp.Data;

namespace CarApp.Logic
{
    public class CarLogic
    {
        string name;
        int age;
        double priceOfPurchase, mileage;
        bool involvedInAccident;
        public List<SUV> suvList = new List<SUV>();
        public List<Van> vanList = new List<Van>();
        public List<Car> carList = new List<Car>();

        public double getTotalValue()
        {
            double totalValue = 0;

            for (int i = 0; i < suvList.Count; i++)
            {
                name = suvList[i].Name;
                age = suvList[i].Age;
                priceOfPurchase = suvList[i].PriceOfPurchase;
                mileage = suvList[i].Mileage;
                involvedInAccident = suvList[i].InvolvedInAccident;
                SUV suv = new SUV(name, age, priceOfPurchase, mileage, involvedInAccident);
                totalValue += suv.GetCurrentValue();
            }
            for (int i = 0; i < vanList.Count; i++)
            {
                name = vanList[i].Name;
                age = vanList[i].Age;
                priceOfPurchase = vanList[i].PriceOfPurchase;
                mileage = vanList[i].Mileage;
                involvedInAccident = vanList[i].InvolvedInAccident;
                Van van = new Van(name, age, priceOfPurchase, mileage, involvedInAccident);
                totalValue += van.GetCurrentValue();
            }
            for (int i = 0; i < carList.Count; i++)
            {
                name = carList[i].Name;
                age = carList[i].Age;
                priceOfPurchase = carList[i].PriceOfPurchase;
                mileage = carList[i].Mileage;
                involvedInAccident = carList[i].InvolvedInAccident;
                Car car = new Car(name, age, priceOfPurchase, mileage, involvedInAccident);
                totalValue += car.GetCurrentValue();
            }
            return totalValue;
        }

        public string GetVehicleDetails(List<Car> carList, List<Van> vanList, List<SUV> suvList)
        {
            string result = "";
            foreach (var c in carList)
            {
                var car = new Car(c.Name, c.Age, c.PriceOfPurchase, c.Mileage, c.InvolvedInAccident);
                result += "Vehicle: " + c.Name + Environment.NewLine +
                    "Vehicle Age(Years): " + c.Age + Environment.NewLine +
                    "Sale Price: " + c.PriceOfPurchase + Environment.NewLine +
                    "Mileage: " + c.Mileage + Environment.NewLine +
                    "Involved in Accident: " + c.InvolvedInAccident + Environment.NewLine +
                    "Current Value: R" + car.GetCurrentValue() + Environment.NewLine;
            }
            foreach (var v in vanList)
            {
                var suv = new Van(v.Name, v.Age, v.PriceOfPurchase, v.Mileage, v.InvolvedInAccident);
                result += "Vehicle: " + v.Name + Environment.NewLine +
                    "Vehicle Age(Years): " + v.Age + Environment.NewLine +
                    "Sale Price: " + v.PriceOfPurchase + Environment.NewLine +
                    "Mileage: " + v.Mileage + Environment.NewLine +
                    "Involved in Accident: " + v.InvolvedInAccident + Environment.NewLine +
                    "Current Value: R" + suv.GetCurrentValue() + Environment.NewLine;
            }
            foreach (var s in suvList)
            {
                var van = new Van(s.Name, s.Age, s.PriceOfPurchase, s.Mileage, s.InvolvedInAccident);
                result += "Vehicle: " + s.Name + Environment.NewLine +
                    "Vehicle Age(Years): " + s.Age + Environment.NewLine +
                    "Sale Price: " + s.PriceOfPurchase + Environment.NewLine +
                    "Mileage: " + s.Mileage + Environment.NewLine +
                    "Involved in Accident: " + s.InvolvedInAccident + Environment.NewLine +
                    "Current Value: R" + van.GetCurrentValue() + Environment.NewLine;
            }

            result += Environment.NewLine + "Total Price: R" + getTotalValue();

            return result;
        }
    }
}
