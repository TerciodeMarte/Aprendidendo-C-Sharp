using System;

namespace Condicionales 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿Que edad tienes?");
            int edad = int.Parse(Console.ReadLine());
            Console.WriteLine("¿Tienes Carnet?");
            string carnet = (Console.ReadLine());

            if (edad >= 18 && carnet=="Si" )
            {
                Console.WriteLine("Puedes Conducir");
            }else{
                Console.WriteLine("No puedes jaja saludos");
            }
        }
    }
}