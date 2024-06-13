using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class FuncionarioService : PessoaService
    {
        private FuncionarioRepository repository;

        public FuncionarioService()
        {
            repository = new FuncionarioRepository();
        }
        public void InserirFuncionario(Funcionario funcionario)
        {
            repository.InserirFuncionario(funcionario);
        }
    }
}
