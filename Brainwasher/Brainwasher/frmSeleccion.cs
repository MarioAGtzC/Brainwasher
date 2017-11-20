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
        public Bitmap grey = Properties.Resources.gris;
        public Bitmap green = Properties.Resources.verde;
        public Bitmap red = Properties.Resources.rojo;
        public Bitmap blue = Properties.Resources.azul;
        public Bitmap purple = Properties.Resources.morado;
        public Bitmap card;

        public frmSeleccion()
        {
            InitializeComponent();
        }

        public frmSeleccion(Bitmap character)
        {
            this.card = character;
            InitializeComponent();
            picBxCard.BackgroundImage = card;
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

        private void bttnCards_Click(object sender, EventArgs e)
        {
            
                this.Close();
                frmCards cards = new frmCards();
                cards.Show();
                cards.TopMost = true;
            
        }

        private void bttnExit_MouseEnter(object sender, EventArgs e)
        {
            bttnExit.BackgroundImage = red;
        }

        private void bttnExit_MouseLeave(object sender, EventArgs e)
        {
            bttnExit.BackgroundImage = grey;
        }

        private void bttnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttnVersus_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este modo de juego solo esta disponible en la versión premium." +
                "\nEsta puede ser obtenida por $19 en la pagina:\nwww.waterwolf.com.mx", "Versión Premium", MessageBoxButtons.OK);
        }

        public void getMessageBox()
        {
            MessageBox.Show("Necesita iniciar sesión para realizar está acción", "Iniciar Sesión");
        }

        private void bttnPlay_Click(object sender, EventArgs e)
        {
            if (lblUser.Text == "Usuario")
            {
                getMessageBox();
            }
            else
            {
                
            }
        }

        private void bttnLogin_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin login = new frmLogin();
            login.Show();
            login.TopMost = true;
        }
    }
}
