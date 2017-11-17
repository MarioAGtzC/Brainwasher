namespace Brainwasher
{
    partial class frmCards
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
            this.lblLayout = new System.Windows.Forms.Label();
            this.picBxCard = new System.Windows.Forms.PictureBox();
            this.bttnPipila = new System.Windows.Forms.Button();
            this.btnnHidalgo = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.bttnUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBxCard)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLayout
            // 
            this.lblLayout.BackColor = System.Drawing.Color.Black;
            this.lblLayout.Location = new System.Drawing.Point(0, 533);
            this.lblLayout.Name = "lblLayout";
            this.lblLayout.Size = new System.Drawing.Size(1186, 174);
            this.lblLayout.TabIndex = 0;
            // 
            // picBxCard
            // 
            this.picBxCard.BackColor = System.Drawing.Color.Transparent;
            this.picBxCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBxCard.Location = new System.Drawing.Point(302, 30);
            this.picBxCard.Name = "picBxCard";
            this.picBxCard.Size = new System.Drawing.Size(578, 500);
            this.picBxCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBxCard.TabIndex = 1;
            this.picBxCard.TabStop = false;
            this.picBxCard.WaitOnLoad = true;
            // 
            // bttnPipila
            // 
            this.bttnPipila.BackgroundImage = global::Brainwasher.Properties.Resources.pipila_gif;
            this.bttnPipila.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bttnPipila.Location = new System.Drawing.Point(12, 546);
            this.bttnPipila.Name = "bttnPipila";
            this.bttnPipila.Size = new System.Drawing.Size(145, 145);
            this.bttnPipila.TabIndex = 2;
            this.bttnPipila.UseVisualStyleBackColor = true;
            this.bttnPipila.Click += new System.EventHandler(this.bttnPipila_Click);
            // 
            // btnnHidalgo
            // 
            this.btnnHidalgo.BackgroundImage = global::Brainwasher.Properties.Resources.hidalgo_gif;
            this.btnnHidalgo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnnHidalgo.Location = new System.Drawing.Point(265, 546);
            this.btnnHidalgo.Name = "btnnHidalgo";
            this.btnnHidalgo.Size = new System.Drawing.Size(145, 145);
            this.btnnHidalgo.TabIndex = 3;
            this.btnnHidalgo.UseVisualStyleBackColor = true;
            this.btnnHidalgo.Click += new System.EventHandler(this.btnnHidalgo_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Location = new System.Drawing.Point(522, 546);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(145, 145);
            this.button3.TabIndex = 4;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.Location = new System.Drawing.Point(779, 546);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(145, 145);
            this.button4.TabIndex = 5;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // bttnUser
            // 
            this.bttnUser.Location = new System.Drawing.Point(1025, 546);
            this.bttnUser.Name = "bttnUser";
            this.bttnUser.Size = new System.Drawing.Size(145, 145);
            this.bttnUser.TabIndex = 6;
            this.bttnUser.UseVisualStyleBackColor = true;
            this.bttnUser.Click += new System.EventHandler(this.bttnUser_Click);
            // 
            // frmCards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Brainwasher.Properties.Resources.Brainwasher_logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1182, 703);
            this.Controls.Add(this.bttnUser);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnnHidalgo);
            this.Controls.Add(this.bttnPipila);
            this.Controls.Add(this.picBxCard);
            this.Controls.Add(this.lblLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCards";
            this.Text = "frmCards";
            ((System.ComponentModel.ISupportInitialize)(this.picBxCard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblLayout;
        private System.Windows.Forms.PictureBox picBxCard;
        private System.Windows.Forms.Button bttnPipila;
        private System.Windows.Forms.Button btnnHidalgo;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button bttnUser;
    }
}