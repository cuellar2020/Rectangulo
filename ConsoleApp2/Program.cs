using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese coordenadas :");
            Rectangulo rectangulo = new Rectangulo();
            //leer coordenadas

             Console.WriteLine("Ingrese y3");
            int y3 = int.Parse(Console.ReadLine());
            rectangulo.p3 = new Puntos(0, y3);

            Console.WriteLine("Ingrese y1 ");
            int y1=int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese x1 ");
            int x1 = int.Parse(Console.ReadLine());
            rectangulo.p1 = new Puntos(x1,y1);

            Console.WriteLine("Ingrese x2");
            int x2  = int.Parse(Console.ReadLine());
            rectangulo.p2 = new Puntos(x2,0);

            int area = rectangulo.CalcularArea();
            int perimmetro = rectangulo.CalcularPerimetro();

            Console.WriteLine("El area del rectangulo es: "+area);
            Console.WriteLine("El perimetro del rectangulo es: "+ perimmetro);

            Console.Read();
        }
    }
}
