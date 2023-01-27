using System;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Caballo babieca=new Caballo("Babieca");
            Humano Albano=new Humano("Albano");
            Gorila copito=new Gorila("Copito");

            Mamifero Bucefalo = new Caballo("Bucefalo");
            //babieca.getnombreSerVivo();
        }
    }
    class Mamifero
    {
        public Mamifero(String nombre)
        {
            nombreSerVivo=nombre;
        }

        public void respirar()
        {
            Console.WriteLine("Soy capaz de respirar");

        }
        public virtual void pensar()
        {
            Console.WriteLine("pensamiento basico");
        }
        public void cuidarCrias()
        {
            Console.WriteLine("Cuido de mis crias hasta que se valgan por si solas");
        }
        public void getnombreSerVivo()
        {
            Console.WriteLine(nombreSerVivo);
        }
        
        private String nombreSerVivo;

    }
    class Caballo : Mamifero
    {
        public Caballo(String nombreCaballo) : base(nombreCaballo)
        {
            
        }
        public void galopar()
        {
            Console.WriteLine("Soy capaz de galopar");
        }
    }
    class Humano : Mamifero
    {
        public Humano(String nombreHumano) : base(nombreHumano)
        {

        }
        public override void pensar() { 
            Console.WriteLine("Soy capaz de pensar"); 
        }
    }
    class Gorila : Mamifero
    {
        public Gorila(String nombreGorila) : base(nombreGorila)
        {

        }
        public void trepar()
        {
            Console.WriteLine("Soy capaz de trepar");
        }
    }
}