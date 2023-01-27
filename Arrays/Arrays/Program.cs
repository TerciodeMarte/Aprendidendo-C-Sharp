using System;


namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arrays Explicitos
             /*int[] edades = new int[4];
             edades[0] = 15;
             edades[1] = 24;
             edades[2] = 5;
             edades[3] = 10;*/

            //int[] edades = { 15, 24, 5, 10 };

            //Console.WriteLine(edades[1]);

            //Arrays Implicito
            var datos = new[] { "Albano", "Díez", "España" };

            //Arrays de Objetos
            Empleados[] arrayEmpleados = new Empleados[2];
            arrayEmpleados[0] = new Empleados("Albano", 25);
            Empleados Ana=new Empleados("Ana",40);
            arrayEmpleados[1] = Ana;

            //Arrays Anonimos

            var personas = new[]
            {
                new { Nombre = "Juan", Edad = 19 },
                new { Nombre = "Maria", Edad = 49 },
                new { Nombre = "Diana", Edad = 35 },
            };

            //Recorrer Arrays

            /*for(int i = 0; i < edades.Length; i++)
            {
                Console.WriteLine(edades[i]);
            }*/
            for(int i = 0; i < arrayEmpleados.Length; i++)
            {
                Console.WriteLine(arrayEmpleados[i].getInfo());
            }
            foreach(var contador in personas)
            {
                Console.WriteLine(contador);
            }

            

        }
    }

    class Empleados
    {
        public Empleados(String nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }
        public String getInfo()
        {
            return "El nombre es "+ nombre + " y la edad es " + edad;
        }
        String nombre;
        int edad;
    }
}
