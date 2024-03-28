using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RD.Rental.Repository.Model
{
    public enum FuelType
    {
        Petrol,
        Diesel,
        Electric
    }

    public class Car
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Rent { get; set; }
        public FuelType FuelType { get; set; }
        public string Color { get; set; }
        public int KMDriven { get; set; }
        public bool IsAvailable { get; set; }
    }
}
