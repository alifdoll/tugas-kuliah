using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alif3DShapes
{
    [Serializable]
    public class AlifRegularStudent : AlifStudent
    {
       
        private string schoolName;
        private string major;

        public AlifRegularStudent(string id, string name, string address, string school, string major) : base()
        {
            Id = id;
            Name = name;
            Address = address;
            SchoolName = school;
            Major = major;
        }


       
        public string SchoolName { get => schoolName; set => schoolName = value; }
        public string Major { get => major; set => major = value; }

        public override string DisplayData()
        {
            string data = "REGULAR STUDENT " +
                "\nStudent Id = " + Id +
                " \nName = " + Name +
                " \nAddress = " + Address +
                " \nHigh School Name = " + SchoolName +
                " \nMajor = " + Major;

            return data;
        }
    }
}
