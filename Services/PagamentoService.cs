using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class PagamentoService
    {
        private PagamentoRepository repository;

        public PagamentoService()
        {
            repository = new PagamentoRepository();
        }
        public void InserirPagamento(Pagamento pagamento)
        {
            repository.InserirPagamento(pagamento);
        }
    }
}
