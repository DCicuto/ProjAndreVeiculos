using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class CompraService
    {
        private CompraRepository repository;

        public CompraService()
        {
            repository = new CompraRepository();
        }
        public void InserirCompra(Compra compra)
        {
            repository.InserirCompra(compra);
        }

    }
}
