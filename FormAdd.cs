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
    public partial class FormAdd : Form
    {
        FormMenu form;
        AlifShape3D shapes;
        public FormAdd()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            form = (FormMenu)Owner;
            radioButtonSphere.Checked = true;
        }


        private void radioButtonSphere_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxSphere.Enabled = true;
            groupBoxCuboid.Enabled = false;
            groupBoxCylinder.Enabled = false;
        }

        private void radioButtonCuboid_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxSphere.Enabled = false;
            groupBoxCuboid.Enabled = true;
            groupBoxCylinder.Enabled = false;
        }

        private void radioButtonCylinder_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxSphere.Enabled = false;
            groupBoxCuboid.Enabled = false;
            groupBoxCylinder.Enabled = true;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int x = (int)numericUpDownX.Value;
            int y = (int)numericUpDownY.Value;
            int z = (int)numericUpDownZ.Value;

            try
            {
                if (radioButtonSphere.Checked)
                {
                    int diameter = (int)numericUpDownDiamet.Value;
                    shapes = new AlifSphere(x, y, z, diameter);

                    form.listOfShapes.Add(shapes);
                    numericUpDownDiamet.Value = 0;
                }
                else if (radioButtonCuboid.Checked)
                {
                    int width = (int)numericUpDownWidth.Value;
                    int height = (int)numericUpDownHeight.Value;
                    int length = (int)numericUpDownLength.Value;

                    shapes = new AlifCuboid(x, y, z, width, height, length);

                    form.listOfShapes.Add(shapes);

                    numericUpDownWidth.Value = 0;
                    numericUpDownHeight.Value = 0;
                    numericUpDownLength.Value = 0;
                }
                else
                {
                    int height = (int)numericUpDownHeightCy.Value;
                    int diameter = (int)numericUpDownDiamCylin.Value;
                    shapes = new AlifCylinder(x, y, z, diameter, height);

                    form.listOfShapes.Add(shapes);

                    numericUpDownHeightCy.Value = 0;
                    numericUpDownDiamCylin.Value = 0;
                }

                numericUpDownX.Value = 0;
                numericUpDownY.Value = 0;
                numericUpDownZ.Value = 0;
                listBoxInfo.Items.Add("Data Saved");
                MessageBox.Show("Data Saved");
            }catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
