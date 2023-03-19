using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THA_WEEK4_MEGAN_R
{
    public partial class SecondWindowsForm : Form
    {
        public SecondWindowsForm()
        {
            InitializeComponent();
        }

        private void checkBox_agree_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_agree.Checked == true && checkBox_trueChoice.Checked == true)
            {
                butt_MAGIC.Enabled = true;
            }
            if (checkBox_agree.Checked == true && checkBox_trueChoice.Checked == false)
            {
                butt_MAGIC.Enabled = false;
            }
            if (checkBox_trueChoice.Checked == false)
            {
                butt_MAGIC.Enabled = false;
            }
            if (checkBox_agree.Checked == false)
            {
                butt_MAGIC.Enabled = false;
            }
        }

        private void checkBox_trueChoice_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_agree.Checked == true && checkBox_trueChoice.Checked == true)
            {
                butt_MAGIC.Enabled = true;
            }
            if (checkBox_agree.Checked == true && checkBox_trueChoice.Checked == false)
            {
                butt_MAGIC.Enabled = false;
            }
            if (checkBox_trueChoice.Checked == true && checkBox_trueChoice.Checked == false)
            {
                butt_MAGIC.Enabled = false;
            }
            if (checkBox_trueChoice.Checked == false && checkBox_agree.Checked == false)
            {
                butt_MAGIC.Enabled = false;
            }
        }

        public void changeText(string name, string artist)
        {
            label_hi.Text = "Hi, my name is " + name + " and my favorite artist is " + artist + ":)";
        }

        private void butt_MAGIC_Click(object sender, EventArgs e)
        {
            bool magic = false;
            MainWindowsForm form1 = new MainWindowsForm();
            if (radioButton_blue.Checked == true)
            {
                form1.BackColor = Color.DeepSkyBlue;
                magic = true;
            }
            else if (radioButton_purple.Checked == true)
            {
                form1.BackColor = Color.MediumPurple;
                magic = true;
            }
            else if (radioButton_yellow.Checked == true)
            {
                form1.BackColor = Color.Yellow;
                magic = true;
            }
            else if (radioButton_grey.Checked == true)
            {
                form1.BackColor = Color.LightGray;
                magic = true;
            }
            else if (radioButton_pink.Checked == true)
            {
                form1.BackColor = Color.LightPink;
                magic = true;
            }
            if (radioButton_white.Checked == true)
            {
                form1.ForeColor = Color.White;
                magic = true;
            }
            else if (radioButton_brown.Checked == true)
            {
                form1.ForeColor = Color.Brown;
                magic = true;
            }
            else if (radioButton_peach.Checked == true)
            {
                form1.ForeColor = Color.PeachPuff;
                magic = true;
            }
            if (magic == false)
            {
                MessageBox.Show("You have to choose the colors :(", "Oh no!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            form1.Show();
        }
    }
}
