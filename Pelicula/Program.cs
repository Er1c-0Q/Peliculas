using System;
using System.Collections.Generic;

namespace Pelicula
{

    public class Pelicula
    {
        //Campos
        private string titulo, director, pais;
        private Int16 año;

        public Actor actores { get; set; }


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
        Int16 GetAño(){return año;}

        public void SetTitulo(string t){  titulo = t; }
        public void SetAño(Int16 a) {  año = a; }
     
        public void Imprime()
        {
          Console.WriteLine(titulo);
          Console.WriteLine(año);
          System.Console.WriteLine();
          
        }
    }

    public class Actor
    {
        //Propiedades
        private List<Actor> actores = new List<Actor>();
        private string nombre{ get; set; }
        private Int16 edad{ get; set; }

        //Constructores
       public Actor(string n, Int16 a)
        {
            nombre = n;
            edad = a;
        }
        public Actor ()
        {

        }

        //Métodos 
        /*string GetNombre(){return nombre;}
        Int16 GetEdad(){return edad;}*/
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
            Actor actores = new Actor();
            
            Pelicula p1 = new Pelicula ("La Forma del Agua",2017);
            p1.actores = (new Actor("Sally Hawkins", 46));
            p1.actores = (new Actor("Doug Jones", 62));
            p1.Imprime();

            
            Actor actores2 = new Actor();

            Pelicula p2 = new Pelicula("Titanic", 1997);
            p2.actores = (new Actor("Leonardo DiCaprio", 48));
            p2.actores = (new Actor("Kate Winslet", 47));
            p2.Imprime();

            
           /* List<string> peliculas = new List<string>();
                
                peliculas.Add("");
                peliculas.Add("");

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
