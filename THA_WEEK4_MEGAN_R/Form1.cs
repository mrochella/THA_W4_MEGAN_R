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
    public partial class MainWindowsForm : Form
    {
        public MainWindowsForm()
        {
            InitializeComponent();
        }

        private void checkBox_true_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_true.Checked == true && butt_open.Enabled == false)
            {
                butt_submit.Enabled = true;
            }
            if (checkBox_true.Checked == false && butt_open.Enabled == false)
            {
                butt_submit.Enabled = false;
            }
        }

        private void butt_open_Click(object sender, EventArgs e)
        {
            SecondWindowsForm form2 = new SecondWindowsForm();
            form2.Show();
            butt_open.Enabled = false;

            if (checkBox_true.Checked == true && butt_open.Enabled == false)
            {
                butt_submit.Enabled = true;
            }
        }

        private void butt_submit_Click(object sender, EventArgs e)
        {
            SecondWindowsForm form2 = new SecondWindowsForm();
            if (checkBox_true.Checked == true && butt_open.Enabled == false)
            {
                butt_submit.Enabled = true;
            }
            if (textBox_name.Text.Any(char.IsLetter) == false)
            {
                MessageBox.Show("Sorry, names cannot be empty :(", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (textBox_artist.Text.Any(char.IsLetter) == false)
            {
                MessageBox.Show("Sorry, favorite artist cannot be empty :(", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            form2.Show();
            form2.changeText(textBox_name.Text, textBox_artist.Text);
        }

        public void changeBG(Color color)
        {
            this.BackColor = color;
        }
    }
}
