using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alif3DShapes
{
    [Serializable]
    public class AlifCylinder : AlifShape3D
    {
        private int diameter;
        private int height;

        public AlifCylinder(int x, int y, int z, int diameter, int height) : base()
        {
            StartX = x;
            StartY = y;
            StartZ = z;
            Diameter = diameter;
            Height = height;
        }

        public int Diameter { get => diameter; set => diameter = value; }
        public int Height { get => height; set => height = value; }

        public override string DisplayData()
        {
            string data =  "Type = Cylinder" +
                           "\nStartX = " + StartX +
                           "\nStartY = " + StartY +
                           "\nStartZ = " + StartZ +
                           "\nDiameter = " + Diameter +
                           "\nHeight = " + Height +
                           "\nVolume = " + CalculateVolume() +
                           "\n";

            return data;
        }

        protected override double CalculateVolume()
        {
            double volume = Math.PI * Math.Pow((diameter * 2), 2) * Height;
            return volume;
        }
    }
}
