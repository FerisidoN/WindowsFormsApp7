using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int g=0;
    
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2("g");
            if (form2.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Add(form2.ttext);
                
            }
           
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2("g");
            if (form2.ShowDialog() == DialogResult.OK)
            {
               int p= listBox1.SelectedIndex;
                listBox1.Items[p] = form2.ttext;

            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            int p = listBox1.SelectedIndex;
            listBox1.Items.RemoveAt(p);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
