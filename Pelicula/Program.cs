using System;
using System.Collections.Generic;

namespace Pelicula
{

    public class Pelicula
    {
        //Campos
        private List<Actor> actores = new List<Actor>();
        private string titulo { get; set; }
        private string director{ get; set; }
        private string pais{ get; set; }
        private short año { get; set; }

        //Constructores
        public Pelicula()
        {
        }
        public Pelicula(string t, short ñ) : this() 
        {
            this.titulo = t;
            this.año = ñ;
        }

        public void AgregaActor(Actor a){actores.Add(a);}
        

        //Métodos
        public void SetTitulo(string titulo){this.titulo = titulo;}
        public void SetAño(short año){this.año = año;}
        public string GetTitulo(){return this.titulo;}
        public short GetAño(){return this.año;}

        public void ImprimeActores(){
            foreach (var a in actores)
            {
                a.Imprimeactores();
            }
        }
        public void Imprime()
        {
          Console.WriteLine();  
          Console.WriteLine($"{titulo} ({año})");
          
          
        }
    }

    public class Actor
    {
        //Propiedades
        private short edad { get; set; }
        private string nombre { get; set; }

        //Constructores

    public Actor(string n, short e)
    {
        this.nombre = n;
        this.edad = e;
    }

        //Métodos 

        public void Imprimeactores()
        {
            Console.WriteLine($"{nombre} ({edad})");
        }
    }

    // Puedes probar tu código en Main() pero lo importante
    // es que pase las pruebas

    class Program
    {

        static void Main(string[] args)
        {   
            List<Actor> AgregaActor = new List<Actor>();
            
            Pelicula p1 = new Pelicula ("La Forma del Agua",2017);
            AgregaActor.Add(new Actor("Sally Hawkins", 46)); 
            AgregaActor.Add(new Actor("Doug Jones", 46));
            p1.Imprime(); 

            foreach(var m in AgregaActor)
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
