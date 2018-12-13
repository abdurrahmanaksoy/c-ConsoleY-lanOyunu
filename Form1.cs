using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSarp._2018_05_14_TrafikIşığı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

            int sayac = 0;
        private void Form1_Load(object sender, EventArgs e)

        {
            timer1.Interval = 1000;
            timer1.Start();
            
        }

    
        private void btn_Red(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;

        }

        private void btn_Yellow(object sender, EventArgs e)
        {
            button2.BackColor = Color.Yellow;

        }

        private void btn_Green(object sender, EventArgs e)
        {
            button3.BackColor = Color.Green;

        }

       
        private void timer1_Tick(object sender, EventArgs e)
        {

            sayac++;

            label1.Text = sayac.ToString();


            if (sayac < 2)
            {
                button1.Visible = true;
                button2.Visible = false;
                button3.Visible = false;

            }

            else if (sayac >= 2 && sayac < 3)
            {
                button1.Visible = false;
                button2.Visible = true;
                button3.Visible = false;

            }
            else if (sayac >= 3 && sayac < 4)
            {
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = true;

            }
            else
                sayac = 0;

        }

    }
}
