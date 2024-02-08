using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_31_01_class_tsk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = listBox1.SelectedItem == null ? "" : listBox1.SelectedItem.ToString();
            if (str == "Breakfast")
            {
                label1.Text = "Cook an egg on toast";
            }
            else if (str == "Dinner")
            {
                label1.Text = "Heat the soup";

            }
            else if (str == "Supper")
            {
                label1.Text = "Order something with delivery";

            }
            else
            {
                string newTaskDis = textBox2.Text;
                label1.Text = newTaskDis;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string newTask = textBox1.Text;

            listBox1.Items.Add(newTask);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            string str1;

            listBox1.Items.Remove(listBox1.SelectedItem);

            string str = "task completed";
            listBox1.Items.Add(str);


        }
    }
}