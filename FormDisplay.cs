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
            foreach(AlifStudent student in form.listsOfStudent)
            {
                listBoxInfo.Items.AddRange(student.DisplayData().Split('\n'));
                listBoxInfo.Items.Add("");
            }
        }

    
    }
}
