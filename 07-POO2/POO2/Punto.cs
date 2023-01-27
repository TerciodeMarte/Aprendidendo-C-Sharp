using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO2
{
    class Punto
    {
        public Punto(int x,int y)
        {
            //Console.WriteLine($"Coordenada x: {x}, Coordenada y: {y}");
            this.x = x;
            this.y = y;
            contadorDeObjetos++;
        }

        public Punto()
        {
            //Console.WriteLine("Este es el constructor por defecto");
            x = 0;
            y = 0;
            contadorDeObjetos++;
            
        }

        public double distancia(Punto otroPunto) 
        {
            int xDif=this.x - otroPunto.x;
            int yDif=this.y - otroPunto.y;
            double distanciaPuntos = Math.Sqrt(Math.Pow(xDif,2)+Math.Pow(yDif,2));
            return distanciaPuntos;
        }
        public static int getContadorDeObjetos() { return contadorDeObjetos; }

        private int x,y;
        private static int contadorDeObjetos = 0;
    }
}
