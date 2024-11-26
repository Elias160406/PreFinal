using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrefinalProgramacionPunto3D.Entidades
{
  
    public class Punto3D
    {
       
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Z { get; private set; }
        public string Color { get; set; }


        public Punto3D(int x, int y, int z, string color)
        {
            X = x;
            Y = y;
            Z = z;
            Color = color;
        }

        
        public double DistanciaAlOrigen()
        {
            return Math.Sqrt(X * X + Y * Y + Z * Z);
        }

        
        public override string ToString()
        {
            return $"Punto3D(X: {X}, Y: {Y}, Z: {Z}, Color: {Color})";
        }
    }
}
