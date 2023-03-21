using System;
using System.Collections.Generic;

namespace Pelicula
{

    public class Pelicula
    {
        //Campos
        private string titulo, director, pais;
        private Int16 año;
        

        //Constructores
        public Pelicula()
        {

        }
        public Pelicula(string newtit, Int16 newaño)
        {
            titulo = newtit;
            año = newaño;
        }

        //Métodos
        string GetTitulo(){return titulo;}
        string GetDirector(){return director;}
        string GetPais(){return pais;}
        Int16 GetAño(){return año;}

        private List<string> actores = new List<string>();

        public void SetTitulo(string t)
        {
            titulo = t;
        }
        public void SetDirector(string d)
        {
            director = d;
        }
         public void SetPais(string p)
        {
            pais = p;
        }
        public void SetAño(Int16 a)
        {
            año = a;
        }
     
        public void Imprime()
        {
          Console.WriteLine(titulo);
          Console.WriteLine(director);
          Console.WriteLine(pais);
          Console.WriteLine(año);
          System.Console.WriteLine();
          
        }
        public void Imprime2()
        {
          Console.WriteLine(titulo);
          Console.WriteLine(director);
          Console.WriteLine(pais);
          Console.WriteLine(año);
          System.Console.WriteLine();
          
        }


    }

    public class Actor
    {
        //Propiedades
        private string nombre;
        private Int16 edad;

        List<string> act = new List<string>();
        //Constructores
        public Actor(string nom, Int16 ed)
        {
            nombre = nom;
            edad = ed;
        }

        //Métodos 
        string GetNombre(){return nombre;}
        Int16 GetEdad(){return edad;}

        public void SetNombre(string n)
        {
            nombre = n;
        }

        public void SetEdad(Int16 e)
        {
            edad = e;
        }
        public void Imprime()
        {
            Console.WriteLine(nombre +" "+ edad+ " años");
        }
    }

    // Puedes probar tu código en Main() pero lo importante
    // es que pase las pruebas

    class Program
    {
        private static object MessageBox;

        static void Main(string[] args)
        {
           /* Pelicula Agua = new Pelicula ();
            Agua.SetTitulo("La Forma del Agua");
            Agua.SetDirector("Gillermo del Toro");
            Agua.SetPais("Estados Unidos");
            Agua.SetAño(2017);
            Agua.Imprime();

            Pelicula Tit = new Pelicula();
            Agua.SetTitulo("Titanic");
            Agua.SetDirector("James Cameron");
            Agua.SetPais("Estados Unidos");
            Agua.SetAño(1997);
            Agua.Imprime2();*/
            
            List<string> peliculas = new List<string>();
                
                peliculas.Add("Kate Winslet");
                peliculas.Add("Leonardo DiCaprio");

            foreach(string datos in peliculas)
            {
               System.Console.WriteLine(datos);
            }
            
            /*Pelicula p1 = new Pelicula("Titanic", 1997);
            p1.act = new Actor("Leonardo DiCaprio", 48);
            Actor actores2 = new Actor("Leonardo DiCaprio", 48);

            actores.SetNombre("");
            actores.SetEdad(20);
            actores.Imprime();*/


        }
    }
}
