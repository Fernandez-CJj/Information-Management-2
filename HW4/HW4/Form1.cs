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
    public partial class Form1 : Form
    {
        string image = "";
        string selectedGender = "";
        string selectedStatus = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            pictureBox1.Visible = true;
            openFileDialog.Filter = "Image Files|*.jpg;*.png*.jpeg";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog.FileName);
            }
            
            if (radioButton1.Checked)
            {
                selectedGender = radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                selectedGender = radioButton2.Text;
            }

            selectedStatus = comboBox1.SelectedItem.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2(pictureBox1.Image, maskedTextBox1.Text, textBox1.Text, textBox2.Text, selectedGender, selectedStatus, textBox3.Text);
            frm.Show();
            this.Hide();

        }
    }
}
