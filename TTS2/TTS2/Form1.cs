using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTS2
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            this.metroButton1.Click += new System.EventHandler(this.metroButton3_Click);
        }

       

        private void metroButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World!");
        }
    }
}
