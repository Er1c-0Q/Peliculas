using System;
using System.Collections.Generic;

namespace Pelicula
{

    public class Pelicula
    {
        //Campos
        private string titulo { get; set; }
        private string director;
        private string pais;
        private Int16 año { get; set; }



        //Constructores
        public Pelicula(string newtit, Int16 newaño)
        {
            titulo = newtit;
            año = newaño;
        }

        //Métodos
        public void Imprime()
        {
          System.Console.WriteLine();  
          Console.WriteLine(titulo+" "+año);
          
          
        }
    }

    public class Actor
    {
        //Propiedades
        private Int16 edad { get; set; }
        private string nombre { get; set; }
        //public Actor actores { get; set; }

        //Constructores

        public Actor(string n, Int16 e)
        {
            this.nombre = n;
            this.edad = e;
        }

        //Métodos 

        public void Imprimeactores()
        {
            Console.WriteLine(nombre +" "+ edad+ " años");
        }
    }

    // Puedes probar tu código en Main() pero lo importante
    // es que pase las pruebas

    class Program
    {

        static void Main(string[] args)
        {   
            List<Actor> actores = new List<Actor>();
            
            Pelicula p1 = new Pelicula ("La Forma del Agua",2017);
            actores.Add(new Actor("Sally Hawkins", 46)); 
            actores.Add(new Actor("Doug Jones", 46));
            p1.Imprime(); 

            foreach(var m in actores)
            m.Imprimeactores();

            List<Actor> actor = new List<Actor>();

            Pelicula p2 = new Pelicula("Titanic", 1997);
            actor.Add(new Actor("Leonardo DiCaprio", 48)); 
            actor.Add(new Actor("Kate Winslet", 47));
            p2.Imprime();

            foreach(var s in actor)
            s.Imprimeactores();

        }
    }
}
