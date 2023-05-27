using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ecuations;

namespace MetodoDeGaussSeidel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string rpn = textBox1.Text;
            List<string> r = new Tokens().Convert(rpn);
            Queue<string> rpna = new InfixToRpn().Convert(r);


            string answer = "";

            
            foreach(string g in rpna)
            {
                answer += g + "   ";
            }

            textBox2.Text = answer;


            textBox3.Text = new ResolveRpn().Convert(rpna);
        }
    }
}
 