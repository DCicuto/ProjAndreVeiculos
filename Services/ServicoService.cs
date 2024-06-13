using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ServicoService
    {
        private ServicoRepository repository;

        public ServicoService()
        {
            repository = new ServicoRepository();
        }
        public void InserirServico(Servico servico)
        {
            repository.InserirServico(servico);
        }
    }
}

