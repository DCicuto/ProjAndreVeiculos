using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class CarroServicoService
    {
        private CarroServicoRepository repository;

        public CarroServicoService()
        {
            repository = new CarroServicoRepository();
        }
        public void InserirCarroServico(CarroServico carroservico)
        {
            repository.InserirCarroServico(carroservico);
        }
    }
}