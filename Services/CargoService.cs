using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CargoService
    {
        private CargoRepository repository;

        public CargoService()
        {
            repository = new CargoRepository();
        }
        public void InserirCargo(Cargo cargo)
        {
            repository.InserirCargo(cargo);
        }
    }
}
