using Models;
using NuGet.Protocol.Core.Types;
using Repositories;


namespace Services
{
    public class BoletoService
    {
        private BoletoRepository repository;

        public BoletoService()
        {
            repository = new BoletoRepository();
        }
        public void InserirBoleto(Boleto boleto)
        {
            repository.InserirBoleto(boleto);
        }

    }
}
