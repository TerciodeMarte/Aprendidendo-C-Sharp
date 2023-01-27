using System;

namespace Arrays2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int[] numeros = new int[4];
            numeros[0] = 7;
            numeros[1] = 6;
            numeros[2] = 5;
            numeros[3] = 4;
            ProcesadorDatos(numeros);
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]);
            }*/

            int[] arraysElementos = LeerDatos();
            for(int i = 0; i < arraysElementos.Length; i++)
            {
                Console.WriteLine(arraysElementos[i]);
            }
        }
        /*static void ProcesadorDatos(int[] datos)
        {
            for (int i = 0; i < datos.Length; i++)
            {
                datos[i] += 10;
            }
        }*/

        static int[] LeerDatos()
        {
            Console.WriteLine("Cuantos datos quieres guardar");
            int respuesta =int.Parse(Console.ReadLine());
            int[]datos=new int[respuesta];
            for(int i = 0; i < datos.Length; i++)
            {
                Console.WriteLine("Introduce el dato que va en la posicion " + i);
                datos[i] = int.Parse(Console.ReadLine());
            }
            return datos;
        }
    }
}