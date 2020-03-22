using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Inventario.Visible = true;
            Material.Visible = false;
        }

        private void CmdInventario_Click_1(object sender, EventArgs e)
        {
            Inventario.Visible = true;
            Material.Visible = false;
        }

        private void CmdMaterial_Click(object sender, EventArgs e)
        {
            Inventario.Visible = false;
            Material.Visible = true;
        }

    }
}
