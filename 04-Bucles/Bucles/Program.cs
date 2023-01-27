using System;

namespace bucles
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Deseas entrar en el bucle while");
            String respuesta=Console.ReadLine();
            while (respuesta != "no")
            {
                Console.WriteLine("Deseas seguir en el bucle");
                respuesta = Console.ReadLine();
                //Console.Clear();
            }*/

            Random random = new Random();
            int numerorandom = random.Next(0, 100);
            //Console.WriteLine(numerorandom);
            int numerointentos=0;
            int numeroconsola=0;

            Console.WriteLine("Tienes que adivinar un numero entre el 0 y 100, ambos incluidos");

            do
            {
                Console.WriteLine("¿Que numero estas pensando?");
                numeroconsola = int.Parse(Console.ReadLine());
                if (numerorandom > numeroconsola)
                {
                    Console.WriteLine("El numero es mayor");
                    numerointentos++;
                }
                if (numerorandom < numeroconsola)
                {
                    Console.WriteLine("El numero es menor");
                    numerointentos++;
                }



            } while (numerorandom != numeroconsola);

            Console.Clear();
            Console.WriteLine("Enhorabuena,acertastes, el numero era " + numerorandom);
            Console.WriteLine($"Has fallados {numerointentos} veces");
        }
    }
}  
