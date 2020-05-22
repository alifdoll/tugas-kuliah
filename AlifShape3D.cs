using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alif3DShapes
{
    [Serializable]
    public abstract class AlifShape3D
    {
        private int startX;
        private int startY;
        private int startZ;

        protected int StartX { get => startX; set => startX = value; }
        protected int StartY { get => startY; set => startY = value; }
        protected int StartZ { get => startZ; set => startZ = value; }

        protected abstract double CalculateVolume();

        public abstract string DisplayData();
    }
}
