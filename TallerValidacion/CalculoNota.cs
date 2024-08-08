using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerValidacion
{
    public class CalculoNota
    {
        public bool ValidarNota(Nota nota)
        {
            //Asignamos cero a la variable calificación de forma
            //temporal
            double calificacion  = 0;
            
            //Antes  de usar el objeto nota valido que exista
            if(nota != null)
                //Asignamo la nota
                calificacion = nota.Calificacion;

            //Verificamos si ganó o no ganó
            if (calificacion > 5)
                //Retornamos el resultado
                return true;
            else
                //Retornamos el resultado
                return false;

        }
    }
}
