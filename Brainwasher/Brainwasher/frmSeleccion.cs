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
    public partial class frmSeleccion : Form
    {
        public System.Drawing.Bitmap grey = Properties.Resources.gris;
        public System.Drawing.Bitmap green = Properties.Resources.verde;
        public System.Drawing.Bitmap red = Properties.Resources.rojo;
        public System.Drawing.Bitmap blue = Properties.Resources.azul;
        public System.Drawing.Bitmap purple = Properties.Resources.morado;

        public frmSeleccion()
        {
            InitializeComponent();
            
        }

        private void bttnPlay_MouseEnter(object sender, EventArgs e)
        {
            bttnPlay.BackgroundImage = green;
        }

        private void bttnPlay_MouseLeave(object sender, EventArgs e)
        {
            bttnPlay.BackgroundImage = grey;
        }

        private void bttnVersus_MouseEnter(object sender, EventArgs e)
        {
            bttnVersus.BackgroundImage = blue;
        }

        private void bttnVersus_MouseLeave(object sender, EventArgs e)
        {
            bttnVersus.BackgroundImage = grey;
        }

        private void bttnLogin_MouseEnter(object sender, EventArgs e)
        {
            bttnLogin.BackgroundImage = purple;
        }

        private void bttnLogin_MouseLeave(object sender, EventArgs e)
        {
            bttnLogin.BackgroundImage = grey;
        }

        private void bttnCards_MouseEnter(object sender, EventArgs e)
        {
            bttnCards.BackgroundImage = red;
        }

        private void bttnCards_MouseLeave(object sender, EventArgs e)
        {
            bttnCards.BackgroundImage = grey;
        }
    }
}
