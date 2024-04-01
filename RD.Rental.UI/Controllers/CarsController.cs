using RD.Rental.Repository.Model;
using System.Collections.Generic;
using System.Web.Mvc;
using RD.Rental.Repository.Interfaces;
using RD.Rental.Repository.Repo;

namespace RD.Rental.UI.Controllers
{
    public class CarsController : Controller
    {
        // Action method to display all the cars available
        public ActionResult Index()
        {
            var password = "1235465";
            // TODO: Retrieve the list of cars from the database or any other data source
            var cars = GetCars(password);

            // TODO: Pass the list of cars to the view
            return View(cars);

            //TODO: Remove dead code
            var abc = 123;
            var xyz = abc;
        }

        // Helper method to retrieve the list of cars
        private List<Car> GetCars(string password)
        {
            IRepository repo = new MockRepo();
            return repo.GetCars();
            
            var deadCodevar = "abc";
            var moredeadCode = deadCodevar;
        }

        private void DoNothingMethod()
        {
            //TODO: 
            var sampleVariable = "1234";
        }
    }
}
