using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Rectangulo
    {
        public Puntos p1 { get; set; }
        public Puntos p2 { get; set; }
        public Puntos p3 { get; set; }
        public Puntos p4 { get; set; }

        
        
        public int CalcularArea()
        {
            int Area = (p3.y - p1.y) * (p2.x - p1.x);
            return (Area);

        }
        public int CalcularPerimetro() {
            int peri= Math.Abs(((p3.y - p1.y) * 2) + ((p2.x - p1.x) * 2));
            return peri;
        }
    }
}
