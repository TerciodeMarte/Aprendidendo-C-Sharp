using System;
using Interface;

namespace ClasesSelladas
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Caballo babieca = new Caballo("Babieca");
            IMamiferosTerrestres IBabieca = babieca;
            Humano Albano = new Humano("Albano");
            Gorila copito = new Gorila("Copito");

            Mamifero Bucefalo = new Caballo("Bucefalo");
            //babieca.getnombreSerVivo();

            Ballena miWally = new Ballena("Wally");
            miWally.nadar();

            Console.WriteLine(IBabieca.numeroPatas());*/

            Lagartija Juancho=new Lagartija("Juancho");
            Juancho.respirar();
            Humano Albano = new Humano("Albano");
            Albano.respirar();


        }
    }
    abstract class Animales
    {
        public void respirar()
        {
            Console.WriteLine("Soy capaz de respirar");
        }

        public abstract void getNombre();

    }
    class Mamifero: Animales
    {
        public Mamifero(String nombre)
        {
            nombreSerVivo = nombre;
        }
        public virtual void pensar()
        {
            Console.WriteLine("pensamiento basico");
        }
        public void cuidarCrias()
        {
            Console.WriteLine("Cuido de mis crias hasta que se valgan por si solas");
        }
        public override void getNombre()
        {
            Console.WriteLine(nombreSerVivo);
        }

        private String nombreSerVivo;

    }
    class Caballo : Mamifero, IMamiferosTerrestres, IAnimalesEnDeportes, ISaltoConPatas
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
        public sealed override void pensar()
        {
            Console.WriteLine("Soy capaz de pensar");
        }
    }

    class Adolescente : Humano
    {
        public Adolescente(string nombreAdolescente) : base(nombreAdolescente)
        {
        } 
    }
    sealed class Gorila : Mamifero, IMamiferosTerrestres
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
    class Ballena : Mamifero
    {
        public Ballena(String nombreBallena) : base(nombreBallena)
        {

        }
        public void nadar() { Console.WriteLine("Soy capaz de nadar"); }
    }

    class Lagartija : Animales
    {

        private String nombreReptil;

        public Lagartija(string nombreReptil)
        {
            this.nombreReptil = nombreReptil;
        }

        public override void getNombre()
        {
            Console.WriteLine(nombreReptil);
        }
    }
}