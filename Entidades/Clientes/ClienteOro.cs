using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerValidacion.Clientes
{
    public class ClienteOro : Cliente, IOro
    {
        public double Cupo { get; set ; }
        public string Regalo { get ; set ; }


    }
}
