using Models;
using System.ComponentModel.DataAnnotations;

namespace Repositories
{
    public class BoletoRepository
    {
        public bool Insert(Boleto boleto)
        {
            Console.WriteLine("Camada Repository");//Adcionado para teste 
            return true;
        }

    }
}
