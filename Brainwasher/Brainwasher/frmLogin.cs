using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Brainwasher
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            getHide1();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'registroDataSet.Registro' Puede moverla o quitarla según sea necesario.
            this.registroTableAdapter.Fill(this.registroDataSet.Registro);
        }

        private void bttnSignIn_Click(object sender, EventArgs e)
        {
            getHide2();
            getShow1();
        }

        private void bttnLogIn_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users";
            
        }

        private void bttnAgree_Click(object sender, EventArgs e)
        {

        }

        private void bttnStart_Click(object sender, EventArgs e)
        {
            getHide1();
            getShow2();
        }

        public void getHide1()
        {
            label3.Hide();
            label4.Hide();
            label5.Hide();
            txtNewUser.Hide();
            txtNewPassword1.Hide();
            txtNewPassword2.Hide();
            bttnAgree.Hide();
            bttnStart.Hide();
            label6.Text = "¿No tiene una cuenta?";
        }

        public void getHide2()
        {
            label1.Hide();
            label2.Hide();
            cmbBxUser.Hide();
            txtPassword.Hide();
            bttnLogIn.Hide();
            bttnSignIn.Hide();
            label6.Text = "¿Ya tiene una cuenta?";
        }

        public void getShow1()
        {
            label3.Show();
            label4.Show();
            label5.Show();
            txtNewUser.Show();
            txtNewPassword1.Show();
            txtNewPassword2.Show();
            bttnAgree.Show();
            bttnStart.Show();
        }

        public void getShow2()
        {
            label1.Show();
            label2.Show();
            cmbBxUser.Show();
            txtPassword.Show();
            bttnLogIn.Show();
            bttnSignIn.Show();
        }
    }
}
