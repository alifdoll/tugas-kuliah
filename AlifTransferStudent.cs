using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alif3DShapes
{
    [Serializable]
    public class AlifTransferStudent : AlifStudent
    {
       
        private string previousSchool;
        private string previousProgram;
        private int schoolCred;

        public AlifTransferStudent(string id, string name, string address, string previousSchool, string previousMajor, int credNum) : base()
        {
            Id = id;
            Name = name;
            Address = address;
            PreviousSchool = previousSchool;
            PreviousProgram = previousMajor;
            SchoolCred = credNum;
        }

      
        public string PreviousSchool { get => previousSchool; set => previousSchool = value; }
        public string PreviousProgram { get => previousProgram; set => previousProgram = value; }
        public int SchoolCred { get => schoolCred; set => schoolCred = value; }

        public override string DisplayData()
        {
            string data = "TRANSFER STUDENT " +
                "\nStudent Id = " + Id +
                " \nName = " + Name +
                " \nAddress = " + Address +
                " \nPrevious School Name = " + PreviousSchool +
                " \nPrevious Major = " + PreviousProgram +
                " \nSchool Credits / SKS = " + SchoolCred;

            return data;
        }
    }
}
