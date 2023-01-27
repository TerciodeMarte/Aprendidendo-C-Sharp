using System;

namespace switchs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Que transporte quieres utilizar(coche,tren o avion)");
            String transporte=Console.ReadLine();
            switch(transporte){
                case "coche":
                    Console.WriteLine("Vas a tardar 20 minutos");
                    break;
                case "tren":
                    Console.WriteLine("Vas a tardar 10 minutos");
                    break ;
                case "avion":
                    Console.WriteLine("Vas a tardar menos de 10 minutos");
                    break;
                default: Console.WriteLine("Ese transporte no me vale");
                    break;
            }
        }
    }
}