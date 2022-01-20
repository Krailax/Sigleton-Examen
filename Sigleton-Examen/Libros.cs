using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sigleton_Examen
{
    public class Libros
    {
        public string nombre { set; get; }
        public string autor { set; get; }
        public string año { set; get; }
        public string tipolibro { set; get; }

        public Libros(string nombre,string autor,string año,string tipolibro)
        {
            this.nombre = nombre;
            this.autor = autor;
            this.año = año;
            this.tipolibro = tipolibro;
        }


    }
}
