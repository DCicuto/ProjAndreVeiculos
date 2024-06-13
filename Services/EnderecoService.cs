using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class EnderecoService
    {

        private EnderecoRepository repository;

        public EnderecoService()
        {
            repository = new EnderecoRepository();
        }
        public void InserirEndereco(Endereco endereco)
        {
            repository.InserirEndereco(endereco);
        }
    }
}