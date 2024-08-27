using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerValidacion.Ventas
{
    public class Producto
    {
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        private double precio;
        public double Precio 
        {
            get { return precio; }
            set {
                if (value >= 0)
                    precio = value;
                else 
                    precio = 0;                  
            } 
        }
    }
}
