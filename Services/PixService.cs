using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class PixService
    {
        private PixRepository repository;

        public PixService()
        {
            repository = new PixRepository();
        }
        public void InserirPix(Pix pix)
        {
            repository.InserirPix(pix);
        }
    }
}
