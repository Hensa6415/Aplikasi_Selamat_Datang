using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasTiga1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTampilkan_Click(object sender, EventArgs e)
        {
            lNim.Text = "25.11.6415";
            lNama.Text = "Hensa Katelu";
            lKelas.Text = "25 S1 IF 03";
        }

        private void btnKosongkan_Click(object sender, EventArgs e)
        {
            lNim.Text = "";
            lNama.Text = "";
            lKelas.Text = "";

        }
    }
}
