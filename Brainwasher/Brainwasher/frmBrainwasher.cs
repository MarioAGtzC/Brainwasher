using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Brainwasher
{
    public partial class frmBrainwasher : Form
    {
        public System.Drawing.Bitmap grey = Properties.Resources.gris;
        public System.Drawing.Bitmap green = Properties.Resources.verde;
        public System.Drawing.Bitmap red = Properties.Resources.rojo;
        public System.Drawing.Bitmap blue = Properties.Resources.azul;
        public System.Drawing.Bitmap purple = Properties.Resources.morado;

        public frmBrainwasher()
        {
            InitializeComponent();
            lblBIEN.BackColor = Color.Green;
            lblVENI.BackColor = Color.White;
            lblDO_A.BackColor = Color.Red;

            lblBRAI.BackColor = Color.Green;
            lblNWA.BackColor = Color.White;
            lblSHER.BackColor = Color.Red;

            lblVENI.ForeColor = Color.SaddleBrown;
            lblNWA.ForeColor = Color.SaddleBrown;

            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.Width = 800;
            this.Height = 500;
        }

        private void bttnBegin_Click(object sender, EventArgs e)
        {
            frmSeleccion seleccion = new frmSeleccion();
            seleccion.ShowDialog();
        }

        private void bttnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttnBegin_MouseLeave(object sender, EventArgs e)
        {
            bttnBegin.BackgroundImage = grey;
        }

        private void bttnBegin_MouseEnter(object sender, EventArgs e)
        {
            bttnBegin.BackgroundImage = green;
        }

        private void bttnExit_MouseEnter(object sender, EventArgs e)
        {
            bttnExit.BackgroundImage = red;
        }

        private void bttnExit_MouseLeave(object sender, EventArgs e)
        {
            bttnExit.BackgroundImage = grey;
        }
    }
}
