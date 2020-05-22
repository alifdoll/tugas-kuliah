using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alif3DShapes
{
    public partial class FormDisplay : Form
    {
        FormMenu form;
        public FormDisplay()
        {
            InitializeComponent();
        }

        private void FormDisplay_Load(object sender, EventArgs e)
        {
            form = (FormMenu)Owner;
        }

        private void radioButtonAll_CheckedChanged(object sender, EventArgs e)
        {
            listBoxInfo.Items.Clear();

            foreach(AlifShape3D shapes in form.listOfShapes)
            {
                listBoxInfo.Items.AddRange(shapes.DisplayData().Split('\n'));
            }
            listBoxInfo.Items.Add("");
        }

        private void radioButtonSphere_CheckedChanged(object sender, EventArgs e)
        {
            listBoxInfo.Items.Clear();

            foreach (AlifShape3D shapes in form.listOfShapes)
            {
                if(shapes is AlifSphere) listBoxInfo.Items.AddRange(shapes.DisplayData().Split('\n'));
            }
            listBoxInfo.Items.Add("");
        }

        private void radioButtonCuboid_CheckedChanged(object sender, EventArgs e)
        {

            listBoxInfo.Items.Clear();

            foreach (AlifShape3D shapes in form.listOfShapes)
            {
                if (shapes is AlifCuboid) listBoxInfo.Items.AddRange(shapes.DisplayData().Split('\n'));
            }

            listBoxInfo.Items.Add("");
        }

        private void radioButtonCylinder_CheckedChanged(object sender, EventArgs e)
        {

            listBoxInfo.Items.Clear();

            foreach (AlifShape3D shapes in form.listOfShapes)
            {
                if (shapes is AlifCylinder) listBoxInfo.Items.AddRange(shapes.DisplayData().Split('\n'));
            }
            listBoxInfo.Items.Add("");
        }
    }
}
