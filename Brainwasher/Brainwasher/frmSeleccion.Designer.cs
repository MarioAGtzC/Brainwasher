namespace Brainwasher
{
    partial class frmSeleccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSeleccion));
            this.lblUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bttnCards = new System.Windows.Forms.Button();
            this.bttnVersus = new System.Windows.Forms.Button();
            this.bttnLogin = new System.Windows.Forms.Button();
            this.bttnPlay = new System.Windows.Forms.Button();
            this.picBxCard = new System.Windows.Forms.PictureBox();
            this.lblGames = new System.Windows.Forms.Label();
            this.bttnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBxCard)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.SystemColors.Control;
            this.lblUser.Location = new System.Drawing.Point(1008, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(123, 50);
            this.lblUser.TabIndex = 13;
            this.lblUser.Text = "Usuario";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1180, 685);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 12;
            // 
            // bttnCards
            // 
            this.bttnCards.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttnCards.BackgroundImage")));
            this.bttnCards.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttnCards.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bttnCards.FlatAppearance.BorderSize = 0;
            this.bttnCards.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnCards.Location = new System.Drawing.Point(738, 437);
            this.bttnCards.Name = "bttnCards";
            this.bttnCards.Size = new System.Drawing.Size(288, 169);
            this.bttnCards.TabIndex = 11;
            this.bttnCards.Text = "Personajes";
            this.bttnCards.UseVisualStyleBackColor = true;
            this.bttnCards.Click += new System.EventHandler(this.bttnCards_Click);
            this.bttnCards.MouseEnter += new System.EventHandler(this.bttnCards_MouseEnter);
            this.bttnCards.MouseLeave += new System.EventHandler(this.bttnCards_MouseLeave);
            // 
            // bttnVersus
            // 
            this.bttnVersus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttnVersus.BackgroundImage")));
            this.bttnVersus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttnVersus.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bttnVersus.FlatAppearance.BorderSize = 0;
            this.bttnVersus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnVersus.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnVersus.Location = new System.Drawing.Point(738, 114);
            this.bttnVersus.Name = "bttnVersus";
            this.bttnVersus.Size = new System.Drawing.Size(288, 169);
            this.bttnVersus.TabIndex = 10;
            this.bttnVersus.Text = "Multijugador";
            this.bttnVersus.UseVisualStyleBackColor = true;
            this.bttnVersus.Click += new System.EventHandler(this.bttnVersus_Click);
            this.bttnVersus.MouseEnter += new System.EventHandler(this.bttnVersus_MouseEnter);
            this.bttnVersus.MouseLeave += new System.EventHandler(this.bttnVersus_MouseLeave);
            // 
            // bttnLogin
            // 
            this.bttnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttnLogin.BackgroundImage")));
            this.bttnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttnLogin.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bttnLogin.FlatAppearance.BorderSize = 0;
            this.bttnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnLogin.Location = new System.Drawing.Point(156, 437);
            this.bttnLogin.Name = "bttnLogin";
            this.bttnLogin.Size = new System.Drawing.Size(288, 169);
            this.bttnLogin.TabIndex = 9;
            this.bttnLogin.Text = "Login";
            this.bttnLogin.UseVisualStyleBackColor = true;
            this.bttnLogin.Click += new System.EventHandler(this.bttnLogin_Click);
            this.bttnLogin.MouseEnter += new System.EventHandler(this.bttnLogin_MouseEnter);
            this.bttnLogin.MouseLeave += new System.EventHandler(this.bttnLogin_MouseLeave);
            // 
            // bttnPlay
            // 
            this.bttnPlay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttnPlay.BackgroundImage")));
            this.bttnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttnPlay.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bttnPlay.FlatAppearance.BorderSize = 0;
            this.bttnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnPlay.Location = new System.Drawing.Point(156, 114);
            this.bttnPlay.Name = "bttnPlay";
            this.bttnPlay.Size = new System.Drawing.Size(288, 169);
            this.bttnPlay.TabIndex = 8;
            this.bttnPlay.Text = "1 Jugador";
            this.bttnPlay.UseVisualStyleBackColor = true;
            this.bttnPlay.Click += new System.EventHandler(this.bttnPlay_Click);
            this.bttnPlay.MouseEnter += new System.EventHandler(this.bttnPlay_MouseEnter);
            this.bttnPlay.MouseLeave += new System.EventHandler(this.bttnPlay_MouseLeave);
            // 
            // picBxCard
            // 
            this.picBxCard.BackColor = System.Drawing.Color.Transparent;
            this.picBxCard.BackgroundImage = global::Brainwasher.Properties.Resources.user;
            this.picBxCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBxCard.Location = new System.Drawing.Point(1130, 0);
            this.picBxCard.Name = "picBxCard";
            this.picBxCard.Size = new System.Drawing.Size(50, 50);
            this.picBxCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBxCard.TabIndex = 14;
            this.picBxCard.TabStop = false;
            // 
            // lblGames
            // 
            this.lblGames.BackColor = System.Drawing.Color.Transparent;
            this.lblGames.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGames.ForeColor = System.Drawing.SystemColors.Control;
            this.lblGames.Location = new System.Drawing.Point(954, 0);
            this.lblGames.Name = "lblGames";
            this.lblGames.Size = new System.Drawing.Size(53, 50);
            this.lblGames.TabIndex = 15;
            this.lblGames.Text = "0";
            this.lblGames.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bttnExit
            // 
            this.bttnExit.BackgroundImage = global::Brainwasher.Properties.Resources.gris;
            this.bttnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttnExit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bttnExit.FlatAppearance.BorderSize = 0;
            this.bttnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnExit.ForeColor = System.Drawing.SystemColors.Control;
            this.bttnExit.Location = new System.Drawing.Point(12, 641);
            this.bttnExit.Name = "bttnExit";
            this.bttnExit.Size = new System.Drawing.Size(90, 50);
            this.bttnExit.TabIndex = 16;
            this.bttnExit.Text = "Salir";
            this.bttnExit.UseVisualStyleBackColor = true;
            this.bttnExit.Click += new System.EventHandler(this.bttnExit_Click);
            this.bttnExit.MouseEnter += new System.EventHandler(this.bttnExit_MouseEnter);
            this.bttnExit.MouseLeave += new System.EventHandler(this.bttnExit_MouseLeave);
            // 
            // frmSeleccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Brainwasher.Properties.Resources.Brainwasher_logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1182, 703);
            this.Controls.Add(this.bttnExit);
            this.Controls.Add(this.lblGames);
            this.Controls.Add(this.picBxCard);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttnCards);
            this.Controls.Add(this.bttnVersus);
            this.Controls.Add(this.bttnLogin);
            this.Controls.Add(this.bttnPlay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSeleccion";
            this.Text = "frmSeleccion";
            ((System.ComponentModel.ISupportInitialize)(this.picBxCard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picBxCard;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttnCards;
        private System.Windows.Forms.Button bttnVersus;
        private System.Windows.Forms.Button bttnLogin;
        private System.Windows.Forms.Button bttnPlay;
        private System.Windows.Forms.Label lblGames;
        private System.Windows.Forms.Button bttnExit;
    }
}