using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public abstract class PessoaService
    {
        private PessoaRepository repository;

        public PessoaService()
        {
            repository = new PessoaRepository();
        }
        public void InserirPessoa(Pessoa pessoa)
        {
            repository.InserirPessoa(pessoa);
        }
    }
}

