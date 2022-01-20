using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Sigleton_Examen
{
    public class AlmacenamientoLibro
    {
        //Creamos un atributo tipo lista para almacenar todos lo libro
        public List<Libros> listalibro = new List<Libros>();

        //Creamos un contructor Vacio 
        public AlmacenamientoLibro()
        {
            //Creamos Varios Libros
            Libros libro = new Libros("Matematic", "Luis Vicente", "1568", "Razonamiento");
            listalibro.Add(libro);
            Libros libro2 = new Libros("Humano", "Matheys", "1984", "Pensamiento");
            listalibro.Add(libro2);
            Libros libro3 = new Libros("Cielos Nocturno", "Swaim", "1641", "Novela");
            listalibro.Add(libro3);
            Libros libro4 = new Libros("sol Ardiente", "Darius ", "1364", "Vida");
            listalibro.Add(libro4);
        }

        //Mostrar Todos lo libro de la lista de almacenamiento
        public void ImprimirLibros()
        {
            for (int cont=0;cont < listalibro.Count;cont++)
            {
                Console.WriteLine("*****************");
                Console.WriteLine("Libro : "+listalibro[cont].nombre);
                Console.WriteLine("Autor : "+listalibro[cont].autor);
                Console.WriteLine("Año : " + listalibro[cont].año);
                Console.WriteLine("Tipo De Libro : " + listalibro[cont].tipolibro);
                Console.WriteLine("*****************");
            }
        }
        //Eliminamos Libro por el usuario
        public void EliminarLibro(int puntero)
        {
            listalibro.RemoveAt(puntero);
            Console.WriteLine("Se ha eliminado el Libro");
            Thread.Sleep(2000);
        }
        //Devuelve la cantidad de libro que se encuentra
        public int CantidadLibro()
        {
           return listalibro.Count;
        }



    }
}
