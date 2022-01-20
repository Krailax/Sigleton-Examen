using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sigleton_Examen
{
    public class Singleton
    {
        //Creamos como atributos unas instacia de clase
        private static Singleton instacia;
        public  AlmacenamientoLibro almacenamientoLibros;

        //El constructor los pasamos a privado
        private Singleton()
        {
            almacenamientoLibros = new AlmacenamientoLibro();
        }
        

        //Creamos una función estástica en donde verificar si ya ha sido creado la clase
        //Si ha sido creada delvolvera la misma clase creada
        //Si no Esta creada , Se Creara la clase
        public static Singleton GetInstance()
        {
            
            if (instacia == null)
            {
                instacia = new Singleton();
            }
            return instacia;
        }
        
        //Creamos un metodos para ingresar al almacenamiento de lo libros
        public void AlmacenamientoLibro()
        {
            almacenamientoLibros.ImprimirLibros();
        }
        public void EliminarLibro(int puntero)
        {
            almacenamientoLibros.EliminarLibro(puntero);
        }


    }
}
