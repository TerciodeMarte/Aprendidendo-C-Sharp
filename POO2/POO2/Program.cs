using System;
//using static System.Math;

namespace POO2
{
    class Program
    {
        static void Main(string[] args)
        {
            //realizarTarea();

            /*double raiz = Sqrt(9);
            double potencia = Pow(3, 4);
            Console.WriteLine(raiz);
            Console.WriteLine(potencia);*/

            var miVariable = new { Nombre = "Albano", Edad = 25 };
            Console.WriteLine(miVariable.Nombre);
        }
        static void realizarTarea()
        {
            Punto origen =new Punto();

            Punto destino = new Punto(128,80);

            double distancia=origen.distancia(destino);

            Console.WriteLine(distancia);

            Console.WriteLine(Punto.getContadorDeObjetos());
            //TODO:
        }
    }
}