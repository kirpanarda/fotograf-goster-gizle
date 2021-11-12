using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UYGULAMA_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_goster_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
        }

        private void button_gizle_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
        }
    }
}
