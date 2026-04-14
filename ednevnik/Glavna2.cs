using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ednevnik
{
    public partial class Glavna2 : Form
    {
        public Glavna2()
        {
            InitializeComponent();
        }

        private void Glavna2_Load(object sender, EventArgs e)
        {

        }

        private void upisniceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            upisnica frm_upisnica = new upisnica();
            frm_upisnica.Show();
        }
    }
}
