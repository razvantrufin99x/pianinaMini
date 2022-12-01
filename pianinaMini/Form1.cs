using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace pianinaMini
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void stop()
        {
            try
            {

                //Console.Beep(1, 1);

            }
            catch { }
        }
        public void play(int f, int d)
        {
            try
            {
                Console.Beep(f, d);
            }
            catch { }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
