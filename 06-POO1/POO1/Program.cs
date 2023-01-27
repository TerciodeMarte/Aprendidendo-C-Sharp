using System;

namespace POO1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Circulo circulo1 = new Circulo();

            //Console.WriteLine(circulo1.CalculoArea(5));

            //Conversor conversor = new Conversor();
            //conversor.Valor(1.45);
            //Console.WriteLine(conversor.Convertidor(1));

            String respuesta;
            String respuesta2;
            Console.WriteLine("Vamos a fabricar tu propio coche");
            Coche coche1 = new Coche();
            Console.WriteLine("Los coches de fabrica vienen con las siguientes caracteristicas");
            Console.WriteLine(coche1.getInfo());
            Console.WriteLine("¿Quieres poner extras?,¿le podemos poner climatizador? ¿y una tapiceria mejor?");
            respuesta = Console.ReadLine();

            if (respuesta.Equals("Si"))
            {
                Console.WriteLine("Vale,¿quieres poner climatizador");
                respuesta2 = Console.ReadLine();
                if (respuesta2.Equals("Si"))
                {
                    coche1.setClimatizador(true);
                }
                else
                {
                    Console.WriteLine("Pasemos entoces a la tapiceria");
                    coche1.setClimatizador(false);
                }
                Console.WriteLine("¿Que tipo de tapiceria quieres?");
                coche1.setTapiceria(Console.ReadLine());

            }
            Console.WriteLine("Listo,asi ha quedado tu coche");
            Console.WriteLine(coche1.getInfo());
        }
    }

    class Circulo
    {
        private double pi = Math.PI;

        public double CalculoArea(int radio) { return pi * radio * radio; }

    }

    class Conversor
    {
        private double euro = 1.253;
        public double Convertidor(double cantidad) { return cantidad * euro; }

        public void Valor(double nuevoValor)
        {
            if (nuevoValor < 1)
            {
                euro = 1.253;
            }
            else
            {
                euro = nuevoValor;
            }
        }

    }

    partial class Coche
    {
        public Coche()
        {
            ruedas = 4;
            largo = 4.10;
            ancho = 2.20;
            tapiceria = "lana";
            climatizador = false;
        }
        public Coche(double largoCoche, double anchoCoche)
        {
            ruedas = 4;
            largo = largoCoche;
            ancho = anchoCoche;

        }
    }


    partial class Coche
    {
        public string getInfo()
        {
            return "Información del coche \n" + "Ruedas:" + ruedas + "\n" + "Largo:" + largo + "\n" + "Ancho:" + ancho + "\n" + "Tapiceria: " + tapiceria + "\n" + "Climatizador: " + climatizador;
        }

        public void setClimatizador(bool climatizador)
        {
            this.climatizador = climatizador;
        }
        public void setTapiceria(string tapiceria)
        {
            this.tapiceria = tapiceria;
        }

        public string getExtras()
        {
            return "Extras del coche:\n" + "Tapiceria: " + tapiceria + "\n" + "Climatizador: " + climatizador;
        }
        private int ruedas;
        private double largo;
        private double ancho;
        private bool climatizador;
        private string tapiceria;
    }
}

    

