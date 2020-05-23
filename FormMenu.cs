using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alif3DShapes
{
    public partial class FormMenu : Form
    {
        public List<AlifStudent> listsOfStudent = new List<AlifStudent>();
        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            if (File.Exists("academicADM.dat"))
            {
                FileStream fileStream = new FileStream("academicADM.dat", FileMode.Open, FileAccess.Read);

                BinaryFormatter formatter = new BinaryFormatter();
                listsOfStudent = formatter.Deserialize(fileStream) as List<AlifStudent>;
                fileStream.Close();
            }
        }

        private void addDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdd form = new FormAdd();
            form.Owner = this;
            form.ShowDialog();
        }

        private void displayDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDisplay form = new FormDisplay();
            form.Owner = this;
            form.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

      
    }
}
