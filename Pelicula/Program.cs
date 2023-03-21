using System;
using System.Collections.Generic;

namespace Pelicula
{

    public class Pelicula
    {
        //Campos
        private string titulo, director, pais;
        private Int16 año;
        private List<Actor> actores = new List<Actor>();

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

        //Constructores


        //Métodos 
        public void Imprime()
        {
            //Console.WriteLine($"{Nombre} ({Año})");
        }
    }

    // Puedes probar tu código en Main() pero lo importante
    // es que pase las pruebas

    class Program
    {


        static void Main(string[] args)
        {
            Pelicula Agua = new Pelicula ();
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
            Agua.Imprime2();

        }
    }
}
