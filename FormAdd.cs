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
    public partial class FormAdd : Form
    {
        FormMenu form;
       
        public FormAdd()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            form = (FormMenu)Owner;
            radioButton1.Checked = true;
        }


      

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string id = textBoxID.Text;
                string name = textBoxName.Text;
                string address = textBoxAddress.Text;
                AlifStudent student;

                if (radioButton1.Checked)
                {
                    string schoolName = textBoxSchoolName.Text;
                    string major = comboBoxMajor.SelectedItem.ToString();
                    student = new AlifRegularStudent(id, name, address, schoolName, major);
                    listBoxInfo.Items.Add("Student Added");
                    form.listsOfStudent.Add(student);
                    FocusClear();
                }
                else
                {
                    string prevSchool = textBoxPrevName.Text;
                    string prevMajor = textBoxPrevMajor.Text;
                    int credits = int.Parse(textBoxCreds.Text);
                    student = new AlifTransferStudent(id, name, address, prevSchool, prevMajor, credits);
                    listBoxInfo.Items.Add("Student Added");
                    form.listsOfStudent.Add(student);
                    FocusClear();
                }

            }catch (Exception error)
            {
                MessageBox.Show(error.Message,"Warning");
            }
        }

        private void FocusClear()
        {
            textBoxID.Clear();
            textBoxName.Clear();
            textBoxAddress.Clear();
            textBoxID.Focus();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            groupBox2.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            groupBox2.Enabled = true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            List<AlifStudent> students = form.listsOfStudent;

            DialogResult userSelect = MessageBox.Show("Save the Data?", "Confirmation", MessageBoxButtons.YesNo);
            if (userSelect == DialogResult.Yes)
            {
                FileStream fileStream = new FileStream("academicADM.dat", FileMode.Create, FileAccess.Write);

                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fileStream, form.listsOfStudent);
                fileStream.Close();
            }
        }
    }
}
