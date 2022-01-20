using System;

namespace Sigleton_Examen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Singleton
            //Evitar Que se crean varias instancia de esta clase
            //Entonces por lo cual solo existe una!
            Singleton BibliotecaEntradaPrincipal = Singleton.GetInstance();
            Singleton BibliotecaEntradaTrasera = Singleton.GetInstance();

            //Creamos una variable para el bucle
            bool vf = true;
            int opcion = 0;
            int opcion2 = 0;
            //Creamos un bucle con la opcion de salir del programa , Ver lo libros y eliminar libro
            do
            {
                //Limpiamos Consolar   
                Console.Clear();
                //Ingrese la opcion el usuario
                do
                {                  
                    Console.WriteLine("Ingrese la Opcion que desear : \n1-Ver Biblioteca en la entrada principal \n2-Ver Biblioteca en la entrada trasera \n3-No entrar a ninguna ");
                    opcion = Convert.ToInt32(Console.ReadLine()); 
                    if (opcion <= 0 || opcion >= 4)
                    {
                        Console.WriteLine("Su opcion no esta registrada");
                    }
                } while (opcion <= 0 || opcion >= 4);

                //ENTRADA PRINCIPAL
                if(opcion == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Ha Ingresado A la Entrada Principal de la biblioteca");
                    //Mostramos todos lo libro de la biblioteca
                    BibliotecaEntradaPrincipal.AlmacenamientoLibro();
                    //Mostramos la opciones del usuario y el seleccionara una
                    do
                    {
                        Console.WriteLine("Ingrese la Opcion que desear : \n1-Eliminar un libro \n2-Salir de la Biblioteca  ");
                        opcion2 = Convert.ToInt32(Console.ReadLine());
                        if (opcion2 <= 0 || opcion2 >= 3)
                        {
                            Console.WriteLine("Su opcion no esta registrada");
                        }
                    } while (opcion2 <= 0 || opcion2 >= 3);

                    if (opcion2==1)
                    {                                          
                        do
                        {
                            //El usuario ingresara un puntero para eliminar un libro
                            Console.WriteLine("Ingrese la posición de libro a eliminar");
                            opcion2 = Convert.ToInt32(Console.ReadLine());
                            if (opcion2 <= 0 || opcion2 >= BibliotecaEntradaPrincipal.almacenamientoLibros.CantidadLibro())
                            {
                                Console.WriteLine("No hay nigún libro en esa posición");
                            }
                        } while (opcion2 <= 0 || opcion2 >= BibliotecaEntradaPrincipal.almacenamientoLibros.CantidadLibro());
                        BibliotecaEntradaPrincipal.EliminarLibro(opcion2);
                        

                    }
                }


                //ENTRADA TRASERA
                if(opcion == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Ha Ingresado A la Entrada Trasera de la biblioteca");
                    //Mostramos todos lo libro de la biblioteca
                    BibliotecaEntradaTrasera.AlmacenamientoLibro();
                    //Mostramos la opciones del usuario y el seleccionara una
                    do
                    {
                        Console.WriteLine("Ingrese la Opcion que desear : \n1-Eliminar un libro \n2-Salir de la Biblioteca  ");
                        opcion = Convert.ToInt32(Console.ReadLine());
                        if (opcion2 <= 0 || opcion2 >= 3)
                        {
                            Console.WriteLine("Su opcion no esta registrada");
                        }
                    } while (opcion2 <= 0 || opcion2 >= 3);

                    if (opcion2 == 1)
                    {
                        do
                        {
                            //El usuario ingresara un puntero para eliminar un libro
                            Console.WriteLine("Ingrese la posición de libro a eliminar");
                            opcion = Convert.ToInt32(Console.ReadLine());
                            if (opcion2 <= 0 || opcion2 >= BibliotecaEntradaTrasera.almacenamientoLibros.CantidadLibro())
                            {
                                Console.WriteLine("No hay nigún libro en esa posición");
                            }
                        } while (opcion2 <= 0 || opcion2 >= BibliotecaEntradaTrasera.almacenamientoLibros.CantidadLibro());
                        //Eliminamos el libro con el puntero que el usuario ingreso
                        BibliotecaEntradaTrasera.EliminarLibro(opcion2);
                    }
                }

                //En conclusion como se puede observa no importa en donde entres o trate de modificar si es, en la principal o la trasera
                //Ya que sera la misma biblioteca por eso el uso de singleton.


                //SALIR DEL CODGIO

                if(opcion == 3)
                {
                    vf = false;
                }


            } while (vf);

            

                    
        }
    }
}
