using System;

namespace PrimeraAplicacion
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Hola Mundo"); //Esto imprime un mensaje en consola
             * 
            int edad;    //Variable Declarada
            edad = 24;   //Variable Inicialicada
            Console.WriteLine(edad);*/

            //---------------------------------------------------------------------------------------------------

            /*Console.WriteLine(7 * 5);  //Multiplicación entre enteros
            Console.WriteLine(7.0 / 5.0); //División entre decimales*/

            //----------------------------------------------------------------------------------------------------

            /*int edad = 19;

            edad++; //Incrementos
            edad += 5;

            Console.WriteLine("Tu edad es de " + edad + " años"); //Concatenación de string y entero
            Console.WriteLine($"Tu edad es de {edad} años"); //Interpolación*/

            //---------------------------------------------------------------------------------------------

            /*var edadPersona = 27; //Declaración implicita no permite cambiar tipo

            Console.WriteLine(edadPersona);*/

            //---------------------------------------------------------------------------------------------------

            /*Conversión Explicita

            double temperatura=22.5;
            int temperaturaSantander;

            temperaturaSantander=(int)temperatura;

            Console.WriteLine(temperaturaSantander);*/

            //---------------------------------------------------------------------------------------------------

            /*int num1 = 0;
            int num2 = 0;

            Console.WriteLine("Introduce el primer numero");
            num1=int.Parse(Console.ReadLine()); //Metodo introduccion por consola y conversion STRING-->INT 
            Console.WriteLine("Introduce el segundo numero");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("La suma de "+ num1 +" y "+num2 + " es " + (num1+num2));*/

            //----------------------------------------------------------------------------------------------------

            /*const int VALOR = 6;
            const int VALOR2 = 7;

            Console.WriteLine("El valor de la constante es {0} ",VALOR, VALOR2);*/

            const double PI = 3.1416;
            Console.WriteLine("Introduce el radio del circulo");
            double radio=double.Parse(Console.ReadLine());
            Console.WriteLine("El area del circulo es " + Math.Pow(radio,2)*PI);



        }
    }
}

