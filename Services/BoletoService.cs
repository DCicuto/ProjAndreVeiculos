using Models;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class BoletoService
    {
        private BoletoRepository _repository;

        public BoletoService()
        {
            _repository = new BoletoRepository();
        }

        public bool Insert(Boleto boleto)
        {
            Console.WriteLine("Camada Service");//Adcionado para teste
            return _repository.Insert(boleto);
        }

    }
}
