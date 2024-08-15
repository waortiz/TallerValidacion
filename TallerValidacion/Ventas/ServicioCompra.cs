using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerValidacion.Ventas
{
    public class ServicioCompra
    {
        public bool Comprar(Producto producto)
        {
            if (producto == null)
                return false;

            if (producto is Nacional)
                return true;
            else if (producto is Importado)
                return true;
            else 
                return false;
        }
    }
}
