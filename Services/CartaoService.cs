using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class CartaoService
    {
        private CartaoRepository repository;

        public CartaoService()
        {
            repository = new CartaoRepository();
        }
        public void InserirCartao(Cartao cartao)
        {
            repository.InserirCartao(cartao);
        }
    }
}