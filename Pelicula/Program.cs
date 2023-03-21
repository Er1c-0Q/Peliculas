using System;
using System.Collections.Generic;

namespace Pelicula
{

    public class Pelicula
    {
        //Campos
        private string titulo;
        private string director;
        private string pais;
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
          System.Console.WriteLine();  
          Console.WriteLine(titulo);
          Console.WriteLine(año);
          
        }
    }

    public class Actor
    {
        //Propiedades
        private List<Actor> actores = new List<Actor>();
        private string nombre{ get; set; }
        private Int16 edad{ get; set; }

        //Constructores
        /*public Actor ()
        {

        }*/

        public Actor(string n, Int16 a)
        {
            nombre = n;
            edad = a;
        }

        //Métodos 
        string GetNombre(){return nombre;}
        Int16 GetEdad(){return edad;}

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
            Pelicula p1 = new Pelicula ("La Forma del Agua",2017);
            Actor actor1 = new Actor("Sally Hawkins", 46);
            Actor actor2 = new Actor("Doug Jones", 46);
            p1.Imprime(); 
            actor1.Imprimeactores();
            actor2.Imprimeactores();

            
           /* Actor actores2 = new Actor();*/

            Pelicula p2 = new Pelicula("Titanic", 1997);
            Actor actor3 = new Actor("Leonardo DiCaprio", 48);
            Actor actor4 = new Actor("Kate Winslet", 47);
            p2.Imprime(); 
            actor1.Imprimeactores();
            actor2.Imprimeactores();
            

            
            /*p2.actores = (new Actor("Leonardo DiCaprio", 48));
            p2.actores = (new Actor("Kate Winslet", 47));*/

            
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
