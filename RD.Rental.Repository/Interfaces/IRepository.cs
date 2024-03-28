using RD.Rental.Repository.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RD.Rental.Repository.Interfaces
{
    public interface IRepository
    {
        IList<Car> GetCars();
    }
}
