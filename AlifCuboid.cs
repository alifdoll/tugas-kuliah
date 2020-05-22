using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alif3DShapes
{
    [Serializable]
    public class AlifCuboid : AlifShape3D
    {
        private int width;
        private int height;
        private int length;

        public AlifCuboid(int x, int y, int z, int widht, int height, int length) : base()
        {
            StartX = x;
            StartY = y;
            StartZ = z;
            Width = widht;
            Height = height;
            Length = length;
        }

        public int Width { get => width; set => width = value; }
        public int Height { get => height; set => height = value; }
        public int Length { get => length; set => length = value; }

        public override string DisplayData()
        {
            string data = "Type = Cuboid" +
                           "\nStartX = " + StartX +
                           "\nStartY = " + StartY +
                           "\nStartZ = " + StartZ +
                           "\nWidth = " + Width +
                           "\nHeight = " + Height +
                           "\nLength = " + Length +
                           "\nVolume = " + CalculateVolume() +
                           "\n";

            return data;
        }

        protected override double CalculateVolume()
        {
            double volume = Length * Width * Height;
            return volume;
        }
    }
}
