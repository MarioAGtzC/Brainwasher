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
    public partial class frmCards : Form
    {
        public Bitmap pipila = Properties.Resources.pipila_gif;
        public Bitmap hidalgo = Properties.Resources.hidalgo_gif;
        public Bitmap user = Properties.Resources.user;

        public frmCards()
        {
            InitializeComponent();
        }

        public void getSeleccion(Bitmap character)
        {
            frmSeleccion seleccion = new frmSeleccion(character);
            seleccion.Show();
            this.Close();
        }

        private void bttnPipila_Click(object sender, EventArgs e)
        {
            picBxCard.Image = pipila;
            DialogResult result = MessageBox.Show("¿Está seguro?", "Importante", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                getSeleccion(pipila);
            }
        }

        private void btnnHidalgo_Click(object sender, EventArgs e)
        {
            picBxCard.Image = hidalgo;
            DialogResult result = MessageBox.Show("¿Está seguro?", "Importante", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                getSeleccion(hidalgo);
            }
        }

        private void bttnUser_Click(object sender, EventArgs e)
        {
            picBxCard.Image = user;
        }
    }
}
