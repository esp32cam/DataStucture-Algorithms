using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Collection;

namespace CW1
{
    public partial class Form1 : Form
    {
        Collection.Collection x = new ArrayCollection(5);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            button4.Enabled = true;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            button5.Enabled = true;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            button6.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            x.add(textBox4.Text);
            MessageBox.Show("Added");
          
            textBox1.Clear(); ;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (x.contain(textBox5.Text))
            {
                MessageBox.Show("Found");
            }
            else
            {
                MessageBox.Show("Not found");
            }
            textBox2.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6_Click(sender, e);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
