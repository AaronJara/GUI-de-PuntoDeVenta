using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuiInventario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void oaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Productos pr = new Productos();
            pr.Show();

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Usuarios us = new Usuarios();
            us.Show();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cacaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Proveedores pr = new Proveedores();
            pr.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //new agre
           // this.Hide();
           
        }

        private void eliminarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
         
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
