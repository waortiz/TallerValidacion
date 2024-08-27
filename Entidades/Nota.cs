using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerValidacion
{
    public class Nota
    {
        public double Calificacion { get; set; }
        /*private double calificacion;
        public double Calificacion
        {
            get { return calificacion; }
            set
            {
                if (value >= 0 && value <= 10)
                    calificacion = value;
                else
                    calificacion = 0;
            }
        }*/
    }
}
