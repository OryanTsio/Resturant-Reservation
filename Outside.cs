using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinuxOs_Project
{
    public partial class Outside : Form
    {
        public Outside(RadioButton rbn)
        {
            InitializeComponent();
            for (int i = 0; i < Controls.Count; i++)
            {
                if (Controls[i] is CheckBox)
                {
                    ((CheckBox)Controls[i]).CheckedChanged += table_checked;
                }
            }
            StaticClass.InitialCheck(this,rbn);
        }
        public void setSeat(bool state)
        {
            
        }
        public string getSeat(string seat)
        {
            return seat;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void table_checked(object sender, EventArgs e)
        {
            string checkText = ((CheckBox)sender).Text;

            if (((CheckBox)sender).CheckState == CheckState.Checked)
            {
                StaticClass.tableNum = int.Parse(new string(checkText.ToList().FindAll(x => x >= '0' && x <= '9').ToArray()));

                MessageBox.Show($"{StaticClass.tableNum} checked");
            }


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
