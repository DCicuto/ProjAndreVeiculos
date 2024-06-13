using Dapper;
using Microsoft.Data.SqlClient;
using Models;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class FuncionarioRepository : PessoaRepository
    {

        private string StrConn = "Server=127.0.0.1; Database=ProjCARROS; User Id=sa; Password=SqlServer2019!; TrustServerCertificate=True;";
        SqlConnection conn;

        public FuncionarioRepository()
        {
            conn = new SqlConnection(StrConn);
        }

        public void InserirFuncionario(Funcionario funcionario)
        {
            conn.Open();
            string query = "INSERT INTO Table_Funcionario (IdCargo, ValorComissao, Comissao) values (@IdCargo, @ValorComissao, @Comissao)";
            conn.Execute(query, funcionario);
            conn.Close();
        }
    }
}
