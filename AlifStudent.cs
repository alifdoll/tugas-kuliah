using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alif3DShapes
{
    [Serializable]
    public abstract class AlifStudent
    {
        private string id;
        private string name;
        private string address;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }

        public abstract string DisplayData();
    }
}
