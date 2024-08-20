using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerValidacion.Clientes
{
    public class ServicioBanco
    {
        private double CUPO = 2000;
        public double ObtenerCupo(Cliente cliente)
        {
            if (cliente == null)
                return 0;

            return CUPO;
        }

        public double ObtenerCupo(IOro cliente)
        {
            if (cliente == null)
                return 0;

            return cliente.Cupo * 2;
        }
    }
}
