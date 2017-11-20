namespace Brainwasher
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbBxUser = new System.Windows.Forms.ComboBox();
            this.registroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registroDataSet = new Brainwasher.RegistroDataSet();
            this.registroTableAdapter = new Brainwasher.RegistroDataSetTableAdapters.RegistroTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNewPassword1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNewUser = new System.Windows.Forms.TextBox();
            this.txtNewPassword2 = new System.Windows.Forms.TextBox();
            this.bttnSignIn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.bttnAgree = new System.Windows.Forms.Button();
            this.bttnLogIn = new System.Windows.Forms.Button();
            this.bttnStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registroDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbBxUser
            // 
            this.cmbBxUser.DataSource = this.registroBindingSource;
            this.cmbBxUser.DisplayMember = "Nombre(s)";
            this.cmbBxUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBxUser.FormattingEnabled = true;
            this.cmbBxUser.Location = new System.Drawing.Point(12, 63);
            this.cmbBxUser.Name = "cmbBxUser";
            this.cmbBxUser.Size = new System.Drawing.Size(231, 46);
            this.cmbBxUser.TabIndex = 4;
            this.cmbBxUser.ValueMember = "Nombre(s)";
            // 
            // registroBindingSource
            // 
            this.registroBindingSource.DataMember = "Registro";
            this.registroBindingSource.DataSource = this.registroDataSet;
            // 
            // registroDataSet
            // 
            this.registroDataSet.DataSetName = "RegistroDataSet";
            this.registroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // registroTableAdapter
            // 
            this.registroTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(12, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 38);
            this.label2.TabIndex = 6;
            this.label2.Text = "Contraseña";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(12, 182);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(231, 45);
            this.txtPassword.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(635, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 38);
            this.label3.TabIndex = 5;
            this.label3.Text = "Usuario";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(577, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 38);
            this.label4.TabIndex = 6;
            this.label4.Text = "Contraseña";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNewPassword1
            // 
            this.txtNewPassword1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword1.Location = new System.Drawing.Point(539, 182);
            this.txtNewPassword1.Name = "txtNewPassword1";
            this.txtNewPassword1.Size = new System.Drawing.Size(231, 45);
            this.txtNewPassword1.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(577, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 76);
            this.label5.TabIndex = 6;
            this.label5.Text = "Confirmar\r\nContraseña";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNewUser
            // 
            this.txtNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewUser.Location = new System.Drawing.Point(539, 63);
            this.txtNewUser.Name = "txtNewUser";
            this.txtNewUser.Size = new System.Drawing.Size(231, 45);
            this.txtNewUser.TabIndex = 8;
            // 
            // txtNewPassword2
            // 
            this.txtNewPassword2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword2.Location = new System.Drawing.Point(539, 320);
            this.txtNewPassword2.Name = "txtNewPassword2";
            this.txtNewPassword2.Size = new System.Drawing.Size(231, 45);
            this.txtNewPassword2.TabIndex = 8;
            // 
            // bttnSignIn
            // 
            this.bttnSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnSignIn.Location = new System.Drawing.Point(12, 380);
            this.bttnSignIn.Name = "bttnSignIn";
            this.bttnSignIn.Size = new System.Drawing.Size(231, 60);
            this.bttnSignIn.TabIndex = 9;
            this.bttnSignIn.Text = "Registrarse";
            this.bttnSignIn.UseVisualStyleBackColor = true;
            this.bttnSignIn.Click += new System.EventHandler(this.bttnSignIn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(5, 338);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(344, 38);
            this.label6.TabIndex = 10;
            this.label6.Text = "¿No tiene una cuenta?";
            // 
            // bttnAgree
            // 
            this.bttnAgree.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnAgree.Location = new System.Drawing.Point(539, 380);
            this.bttnAgree.Name = "bttnAgree";
            this.bttnAgree.Size = new System.Drawing.Size(231, 60);
            this.bttnAgree.TabIndex = 9;
            this.bttnAgree.Text = "Aceptar";
            this.bttnAgree.UseVisualStyleBackColor = true;
            this.bttnAgree.Click += new System.EventHandler(this.bttnAgree_Click);
            // 
            // bttnLogIn
            // 
            this.bttnLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnLogIn.Location = new System.Drawing.Point(12, 248);
            this.bttnLogIn.Name = "bttnLogIn";
            this.bttnLogIn.Size = new System.Drawing.Size(231, 60);
            this.bttnLogIn.TabIndex = 9;
            this.bttnLogIn.Text = "Aceptar";
            this.bttnLogIn.UseVisualStyleBackColor = true;
            this.bttnLogIn.Click += new System.EventHandler(this.bttnLogIn_Click);
            // 
            // bttnStart
            // 
            this.bttnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnStart.Location = new System.Drawing.Point(12, 381);
            this.bttnStart.Name = "bttnStart";
            this.bttnStart.Size = new System.Drawing.Size(231, 60);
            this.bttnStart.TabIndex = 9;
            this.bttnStart.Text = "Ingresar";
            this.bttnStart.UseVisualStyleBackColor = true;
            this.bttnStart.Click += new System.EventHandler(this.bttnStart_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Brainwasher.Properties.Resources.Brainwasher_logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bttnLogIn);
            this.Controls.Add(this.bttnAgree);
            this.Controls.Add(this.bttnStart);
            this.Controls.Add(this.bttnSignIn);
            this.Controls.Add(this.txtNewPassword2);
            this.Controls.Add(this.txtNewUser);
            this.Controls.Add(this.txtNewPassword1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBxUser);
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registroDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.ComboBox cmbBxUser;
        private RegistroDataSet registroDataSet;
        private System.Windows.Forms.BindingSource registroBindingSource;
        private RegistroDataSetTableAdapters.RegistroTableAdapter registroTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNewPassword1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNewUser;
        private System.Windows.Forms.TextBox txtNewPassword2;
        private System.Windows.Forms.Button bttnSignIn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bttnAgree;
        private System.Windows.Forms.Button bttnLogIn;
        private System.Windows.Forms.Button bttnStart;
    }
}