using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW4
{
    public partial class Form2 : Form
    {
        public Form2(Image img, string mask, string firstName, string lastName, string sex, string status, string location)
        {
            InitializeComponent();
            pictureBox1.Image = img;
            maskedTextBox1.Text = mask;
            textBox1.Text = firstName;
            textBox2.Text = lastName;
            textBox4.Text = sex;
            comboBox1.Text = status;
            textBox3.Text = location;

            
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //MessageBox.Show($"");
        }
    }
}
