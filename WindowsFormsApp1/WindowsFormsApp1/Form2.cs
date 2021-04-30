using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            var pos = this.PointToScreen(label1.Location);
            pos = pictureBox1.PointToClient(pos);
            label1.Parent = pictureBox1;
            label1.Location = pos;
            label1.BackColor = Color.Transparent;

            textBox1.BackColor = System.Drawing.ColorTranslator.FromHtml("#294936");
            textBox2.BackColor = System.Drawing.ColorTranslator.FromHtml("#294936");
            textBox3.BackColor = System.Drawing.ColorTranslator.FromHtml("#294936");

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "E-mail or Username")
            {
                textBox1.Text = "";
            }
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "Password")
            {
                textBox2.Text = "";
                textBox2.PasswordChar = '*';
            }

        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "Confirm Password")
            {
                textBox3.Text = "";
                textBox3.PasswordChar = '*';
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }
    }
}
