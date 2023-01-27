using System;

namespace Metodos
{
    class Program
    {
        int numero1 = 5;
        int numero2 = 2;

        static void Main(string[] args)
        {
            //Console.WriteLine (sumaNumeros(2, 4));
            Console.WriteLine(suma(4, 3));
        }

        /*static void sumaNumeros(int x, int y)
        {
            Console.WriteLine(x + y);

        }*/

        //static int sumaNumeros(int x, int y) => x + y;  //Metodo en unsa sola linea

        static int suma(int x, int y) { return x + y; }
        
        static int suma(int x,int y,int z) { return x + y + z; }
    }
}