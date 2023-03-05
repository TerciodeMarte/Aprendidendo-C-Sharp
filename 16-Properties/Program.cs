namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado albano = new Empleado("Albano");

            albano.SALARIO = 1200;

            Console.WriteLine("El salario de Albano es: " + albano.SALARIO);

        }

        class Empleado
        {
            private double salario;
            private string nombre;

            public Empleado(string nombre)
            {
                this.nombre = nombre;
            }

            /*public double getSalario()
            {
                return salario;
            }
            public void setSalario(double salario)
            {
                if (salario < 0)
                {
                    Console.WriteLine("El salario no puede ser Negativo,se le asigna 0");
                    this.salario = 0;
                }
                else
                {
                    this.salario = salario;
                }

            }*/
            public double evaluaSalario(double salario)
            {
                if (salario < 0)
                {
                    Console.WriteLine("El salario no puede ser Negativo,se le asigna 0");
                    return 0;
                }
                else
                {
                    return salario;
                }

            }
            //CREACION DE PROPIEDAD

           /* public double SALARIO
            {
                get { return this.salario; }

                set { this.salario = evaluaSalario(value); }

            }*/

            public double SALARIO
            {
                get=>this.salario;
                set => this.salario = evaluaSalario (value);
            }
        }
    }
}