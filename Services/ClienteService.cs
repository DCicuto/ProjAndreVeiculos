using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ClienteService : PessoaService
    {
        private ClienteRepository repository;

        public ClienteService()
        {
            repository = new ClienteRepository();
        }
        public void InserirCliente(Cliente cliente)
        {
            repository.InserirCliente(cliente);
        }
    }
}
