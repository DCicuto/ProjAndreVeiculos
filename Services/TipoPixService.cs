using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class TipoPixService
    {
        private TipoPixRepository repository;

        public TipoPixService()
        {
            repository = new TipoPixRepository();
        }
        public void InserirTipoPix(TipoPix tipopix)
        {
            repository.InserirTipoPix(tipopix);
        }
    }
}
