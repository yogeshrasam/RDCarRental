using RD.Rental.Repository.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RD.Rental.Repository.Interfaces;

namespace RD.Rental.Repository.Repo
{
    public class MockRepo: IRepository
    {
        public List<Car> GetCars()
        {
            // TODO: Implement the logic to retrieve the list of cars
            // from the database or any other data source
            // For now, returning a dummy list of cars
            //TODO:
            return new List<Car>
                {
                    new Car { Id = 1, Make = "Maruti", Model = "WagonR", Year = 2021, Rent = 1000, FuelType = FuelType.Petrol, Color = "Red", KMDriven = 5000, IsAvailable = true },
                    new Car { Id = 2, Make = "Ford", Model = "Figo", Year = 2015, Rent = 1200, FuelType = FuelType.Petrol, Color = "Blue", KMDriven = 6000, IsAvailable = true },
                    new Car { Id = 3, Make = "Tata", Model = "Nexon", Year = 2022, Rent = 1500, FuelType = FuelType.Diesel, Color = "Black", KMDriven = 4000, IsAvailable = false }
                };
            var deadCodeVariable = 123;
        }
    }
    public class UnusedMethod
    {
        private void A()
        {
            B();
        }

        private void B()
        {
            for (int i=0;i<10;i++)
            {
                var sb = new StringBuilder();
                sb.Append("Hello ").Append(i.ToString());
                Console.WriteLine(sb);
            }       
        }
    }

    public class Date
    {
        private int year;
        private int month;
        private int day;

        public String ConvertToISO()
        {
            return year + "-" + month + "-" + day;
        }

        public String ConvertToIso()
        {
            return year + "-" + month + "-" + day;
        }
    }
    
}
