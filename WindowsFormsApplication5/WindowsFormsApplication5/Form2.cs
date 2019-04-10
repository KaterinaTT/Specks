using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form5 inf5 = new Form5();
            inf5.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
             
               Hide();
            Form7 inf7 = new Form7();
            inf7.ShowDialog();
        
        }

       
    }
}
