using System;

namespace excepciones
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Random random = new Random();
             int numerorandom = random.Next(0, 100);
             //Console.WriteLine(numerorandom);
             int numerointentos = 0;
             int numeroconsola = 0;

             Console.WriteLine("Tienes que adivinar un numero entre el 0 y 100, ambos incluidos");

             do
             {
                 Console.WriteLine("¿Que numero estas pensando?");

                 try
                 {
                     numeroconsola = int.Parse(Console.ReadLine());
                 }
                 catch (Exception e) when (e.GetType()!=typeof(FormatException)) { 
                     Console.WriteLine("No has metido un numero valido");
                 }
                 catch (FormatException e)
                 {
                     Console.WriteLine("No has introducido un numero");
                 }


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

             Console.WriteLine("El programa continua a partir de aqui");*/

            /* checked
             {
                 int numero = int.MaxValue;

                 int resultado = numero + 20;

                 Console.WriteLine(resultado);
             }*/

            Console.WriteLine("Introduce un numero para saber que mes es");
            int numeromes=int.Parse(Console.ReadLine());
            try
            {
                Console.WriteLine(Nombredelmes(numeromes));
            }catch(Exception e) { Console.WriteLine(e.ToString()); }

            Console.WriteLine("Sigo?");


        }

        public static string Nombredelmes(int mes)
        {
            switch (mes)
            {
                case 1: return "Enero";
                case 2: return "Febrero";
                case 3: return "Marzo";
                case 4: return "Abril";
                case 5: return "Mayo";
                case 6: return "Junio";
                case 7: return "Julio";
                case 8: return "Agosto";
                case 9: return "Septiembre";
                case 10: return "Octubre";
                case 11: return "Noviembre";
                case 12: return "Diciembre";
                default: throw new ArgumentOutOfRangeException();

            }
        }
    }
}
