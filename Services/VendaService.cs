using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class VendaService
    {
        private VendaRepository repository;

        public VendaService()
        {
            repository = new VendaRepository();
        }
        public void InserirVenda(Venda venda)
        {
            repository.InserirVenda(venda);
        }

    }
}
