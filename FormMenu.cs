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
        public List<AlifShape3D> listOfShapes = new List<AlifShape3D>();
        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

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

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog
            {
                InitialDirectory = @"G:\Kuliah\Project VStudio Kampus\PBO_Sms_2\Alif3DShapes",
                Title = "Save Shape File",
                Filter = "Shape Data |*.vc"
            };
            saveFile.ShowDialog();
            if(saveFile.FileName != "")
            {
                FileStream fileStream = (FileStream)saveFile.OpenFile();
                BinaryFormatter formatter = new BinaryFormatter();

                formatter.Serialize(fileStream, listOfShapes);
                fileStream.Close();
            }
        }

        private void loadFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog
            {
                InitialDirectory = @"G:\Kuliah\Project VStudio Kampus\PBO_Sms_2\Alif3DShapes",
                Filter = "Shape Data |*.vc"
            };
            openFile.ShowDialog();

            if(openFile.FileName != "")
            {
                FileStream fileStream = (FileStream)openFile.OpenFile();
                BinaryFormatter formatter = new BinaryFormatter();
                listOfShapes = formatter.Deserialize(fileStream) as List<AlifShape3D>;
            }
        }
    }
}
