using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace pianinaMini
{
    public partial class tasta : UserControl
    {
        public tasta()
        {
            InitializeComponent();
        }

        Form1 f;
        
        private void tasta_MouseClick(object sender, MouseEventArgs e)
        {
            f.stop();
            f.play(this.Left+32, 250);

        }

        private void tasta_Load(object sender, EventArgs e)
        {
            //avoiding vs2010pro error of design page
            //and give access to Form1 at loading of control 
            //at runtime or design time
            try
            {
               f =  (Form1)ParentForm;
            }
            catch { }
        }

        private void tasta_MouseEnter(object sender, EventArgs e)
        {
            //f.stop();
            //f.play(this.Left + 32, 250);
        }
    }
}
