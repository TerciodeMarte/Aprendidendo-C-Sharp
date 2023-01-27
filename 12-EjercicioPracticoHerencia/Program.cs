using System;
namespace EjercicioPracticoHerencia {
    class Program
    {
        public static void Main(string[] args)
        {

        }
    }

    class Vehiculo
    {
        private Boolean motor;
        public Vehiculo()
        {
            motor = false;
        }
        public void arrancarMotor()
        {
            motor = true;
            Console.WriteLine("Motor Encendido");
        }

        public void pararMotor()
        {
            motor = false;
            Console.WriteLine("Motor Apagado");
        }
        public virtual void conducir()
        {
            Console.WriteLine("Conducción Basica");
        }
    }
    class Avion : Vehiculo
    {
        public Avion()
        {

        }

        public override void conducir()
        {
            Console.WriteLine("Licencia de Piloto");
        }

    }
    class Coche: Vehiculo
    {
        public Coche()
        {

        }

        public override void conducir()
        {
            Console.WriteLine("Carnet de Conducir");
        }
    }
}