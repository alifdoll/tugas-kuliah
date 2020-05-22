using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alif3DShapes
{
    [Serializable]
    public class AlifSphere : AlifShape3D
    {
        private int diameter;

        public AlifSphere(int x, int y, int z, int diameter)
        {
            StartX = x;
            StartY = y;
            StartZ = z;
            Diameter = diameter;
        }

        public int Diameter { get => diameter; set => diameter = value; }

        public override string DisplayData()
        {
            string data = "Type = Sphere" +
                           "\nStartX = " + StartX +
                           "\nStartY = " + StartY +
                           "\nStartZ = " + StartZ +
                           "\nVolume = " + CalculateVolume() +
                           "\n";
            return data;
        }

        protected override double CalculateVolume()
        {
            double volume = 4 / 3 * Math.PI * Math.Pow((Diameter / 2), 3);
            return volume;
        }
    }
}
