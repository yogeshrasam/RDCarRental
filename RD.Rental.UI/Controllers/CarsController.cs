using RD.Rental.Repository.Model;
using System.Collections.Generic;
using System.Web.Mvc;

namespace RD.Rental.UI.Controllers
{
    public class CarsController : Controller
    {
        // Action method to display all the cars available
        public ActionResult Index()
        {
            // TODO: Retrieve the list of cars from the database or any other data source
            var cars = GetCars();

            // TODO: Pass the list of cars to the view
            return View(cars);
        }

        // Helper method to retrieve the list of cars
        private List<Car> GetCars()
        {
            // TODO: Implement the logic to retrieve the list of cars
            // from the database or any other data source
            // For now, returning a dummy list of cars
            return new List<Car>
                {
                    new Car { Id = 1, Make = "Maruti", Model = "WagonR", Year = 2021, Rent = 1000, FuelType = FuelType.Petrol, Color = "Red", KMDriven = 5000, IsAvailable = true },
                    new Car { Id = 2, Make = "Ford", Model = "Figo", Year = 2015, Rent = 1200, FuelType = FuelType.Petrol, Color = "Blue", KMDriven = 6000, IsAvailable = true },
                    new Car { Id = 3, Make = "Tata", Model = "Nexon", Year = 2022, Rent = 1500, FuelType = FuelType.Diesel, Color = "Black", KMDriven = 4000, IsAvailable = false }
                };
            var deadCodevar = "abc";
        }
    }
}
