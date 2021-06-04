using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //CreateLabel();

        }

        void CreateLabel()
        {
            Label label = new Label();
            Image image = Properties.Resources.mario;
            label.Size = new Size(image.Width, image.Height);

            label.Image = image;
            this.Size = label.Size;
            this.Controls.Add(label);

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            //CreateLabel();
            groupBox1.Controls.Add(engRadioButton);
            //MessageBox.Show(usernameTxtb.Text);
            // MessageBox.Show(usernameTxtb.SelectedText);
            
        }

        private void usernameTxtb_TextChanged(object sender, EventArgs e)
        {

        }

        private void usernameTxtb_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void usernameTxtb_MouseEnter(object sender, EventArgs e)
        {

            if (usernameTxtb.Text == "username")
            {
                usernameTxtb.Text = String.Empty;
            }
        }

        private void usernameTxtb_MouseLeave(object sender, EventArgs e)
        {
            if (usernameTxtb.Text == String.Empty)
            {
                usernameTxtb.Text = "username";
            }
        }

        private void undoBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void redoBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void cutBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.ForeColor = Color.SpringGreen;
                
            }
            else
            {
                checkBox1.ForeColor = Color.Red;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                radioButton1.BackColor = Color.DeepPink;
            }
            else
            {
                radioButton1.BackColor = Color.White;
            }
            if (radioButton2.Checked)
            {
                radioButton2.BackColor = Color.DeepPink;
            }
            else
            {
                radioButton2.BackColor = Color.White;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = dateTimePicker1.Value.ToLongDateString();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            MessageBox.Show(monthCalendar1.SelectionStart.ToString());
        }
    }
}
