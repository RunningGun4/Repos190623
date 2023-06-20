using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zmeika
{
    public partial class Form1 : Form
    {
        public int x = 250;
        public int y = 250;
        public Form1()
        {
            InitializeComponent();
            listBox1.BackColor = Color.Gray;
            timer1.Enabled = false;
            timer1.Interval = 01;
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
        }

       

        private void timer1_Tick(object sender, EventArgs e)
        {

            x++;
            button2.Location = new Point(x, y);

        }

    }
}
