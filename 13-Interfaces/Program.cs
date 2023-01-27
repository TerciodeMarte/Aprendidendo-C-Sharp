using System;
using Interface;

namespace UsoInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Caballo babieca = new Caballo("Babieca");
            IMamiferosTerrestres IBabieca = babieca;
            Humano Albano = new Humano("Albano");
            Gorila copito = new Gorila("Copito");

            Mamifero Bucefalo = new Caballo("Bucefalo");
            //babieca.getnombreSerVivo();

            Ballena miWally = new Ballena("Wally");
            miWally.nadar();

            Console.WriteLine(IBabieca.numeroPatas()); 
        }
    }
    class Mamifero
    {
        public Mamifero(String nombre)
        {
            nombreSerVivo = nombre;
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
    class Caballo : Mamifero, IMamiferosTerrestres,IAnimalesEnDeportes,ISaltoConPatas
    {
        public Caballo(String nombreCaballo) : base(nombreCaballo)
        {

        }
        public void galopar()
        {
            Console.WriteLine("Soy capaz de galopar");
        }
        int IMamiferosTerrestres.numeroPatas() 
        { 
            return 4; 
        }
        public string tipoDeporte()
        {
            return "En ipica";
        }
        public Boolean esOlimpico() 
        { 
            return true; 
        }
        int ISaltoConPatas.numeroPatas() 
        { 
            return 2; 
        }

    }
    class Humano : Mamifero
    {
        public Humano(String nombreHumano) : base(nombreHumano)
        {

        }
        public override void pensar()
        {
            Console.WriteLine("Soy capaz de pensar");
        }
    }
    class Gorila : Mamifero, IMamiferosTerrestres
    {
        public Gorila(String nombreGorila) : base(nombreGorila)
        {

        }
        public void trepar()
        {
            Console.WriteLine("Soy capaz de trepar");
        }
        public int numeroPatas() { return 2; }
    }
    class Ballena: Mamifero
    {
        public Ballena(String nombreBallena):base(nombreBallena)
        {

        }
        public void nadar() { Console.WriteLine("Soy capaz de nadar"); }
    }
}