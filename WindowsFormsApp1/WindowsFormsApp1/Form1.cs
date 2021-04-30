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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var pos = this.PointToScreen(label1.Location);
            pos = pictureBox1.PointToClient(pos);
            label1.Parent = pictureBox1;
            label1.Location = pos;
            label1.BackColor = Color.Transparent;
            
           



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.BackColor = System.Drawing.ColorTranslator.FromHtml("#294936");
            textBox2.BackColor = System.Drawing.ColorTranslator.FromHtml("#294936");
            pictureBox5.BackColor = Color.Transparent;


        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
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
        
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Hide();
        }
    }
}
