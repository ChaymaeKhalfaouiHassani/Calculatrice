using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALC
{
    public partial class Form1 : Form
    {
        string operation = "";
        double resultat=0;
        bool estOperation=false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    textBox1.Text = (resultat + double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (resultat - double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (resultat * double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (resultat / double.Parse(textBox1.Text)).ToString();
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Button but = (Button)sender;
            operation = but.Text;
            resultat=double.Parse(textBox1.Text);
            estOperation=true;
            textBox1.Clear();
        }
        
            private void button9_Click(object sender, EventArgs e)
        {
            Button but =(Button)sender;
            if (textBox1.Text == "0"|| estOperation==true) { textBox1.Clear(); }
            if(but.Text == ".")
            {
                if (!textBox1.Text.Contains(".")) { textBox1.Text = textBox1.Text + but.Text; }
            }
            else
            {
                textBox1.Text = textBox1.Text + but.Text;
            }
            estOperation=false;
        }

        private void button16_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
    }
}
