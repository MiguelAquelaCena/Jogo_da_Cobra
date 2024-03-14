namespace Jogo_da_cobra
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.titulo_jogo_da_cobra = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.TextBox();
            this.Passe = new System.Windows.Forms.TextBox();
            this.BTConfirmar = new System.Windows.Forms.Button();
            this.BTCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Jogo_da_cobra.Properties.Resources.kisspng_snakes_and_ladders_game_android_clip_art_animated_snake_pictures_5a7c988485b4d1_8632212215181149485477;
            this.pictureBox1.Location = new System.Drawing.Point(327, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // titulo_jogo_da_cobra
            // 
            this.titulo_jogo_da_cobra.AutoSize = true;
            this.titulo_jogo_da_cobra.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo_jogo_da_cobra.ForeColor = System.Drawing.Color.Lime;
            this.titulo_jogo_da_cobra.Location = new System.Drawing.Point(22, 9);
            this.titulo_jogo_da_cobra.Name = "titulo_jogo_da_cobra";
            this.titulo_jogo_da_cobra.Size = new System.Drawing.Size(299, 60);
            this.titulo_jogo_da_cobra.TabIndex = 3;
            this.titulo_jogo_da_cobra.Text = "Jogo da Cobra";
            // 
            // Username
            // 
            this.Username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Username.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.ForeColor = System.Drawing.Color.Gray;
            this.Username.Location = new System.Drawing.Point(32, 99);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(267, 13);
            this.Username.TabIndex = 4;
            this.Username.Text = "Username";
            // 
            // Passe
            // 
            this.Passe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Passe.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passe.ForeColor = System.Drawing.Color.Gray;
            this.Passe.Location = new System.Drawing.Point(32, 118);
            this.Passe.Name = "Passe";
            this.Passe.Size = new System.Drawing.Size(267, 13);
            this.Passe.TabIndex = 5;
            this.Passe.Text = "Password";
            this.Passe.UseSystemPasswordChar = true;
            // 
            // BTConfirmar
            // 
            this.BTConfirmar.FlatAppearance.BorderSize = 0;
            this.BTConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTConfirmar.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTConfirmar.ForeColor = System.Drawing.Color.Lime;
            this.BTConfirmar.Location = new System.Drawing.Point(32, 137);
            this.BTConfirmar.Name = "BTConfirmar";
            this.BTConfirmar.Size = new System.Drawing.Size(128, 39);
            this.BTConfirmar.TabIndex = 6;
            this.BTConfirmar.Text = "Confirmar";
            this.BTConfirmar.UseVisualStyleBackColor = true;
            this.BTConfirmar.Click += new System.EventHandler(this.buttonConfirmar_Click);
            // 
            // BTCancelar
            // 
            this.BTCancelar.FlatAppearance.BorderSize = 0;
            this.BTCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTCancelar.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTCancelar.ForeColor = System.Drawing.Color.Lime;
            this.BTCancelar.Location = new System.Drawing.Point(166, 137);
            this.BTCancelar.Name = "BTCancelar";
            this.BTCancelar.Size = new System.Drawing.Size(128, 39);
            this.BTCancelar.TabIndex = 7;
            this.BTCancelar.Text = "Cancelar";
            this.BTCancelar.UseVisualStyleBackColor = true;
            this.BTCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 229);
            this.Controls.Add(this.BTCancelar);
            this.Controls.Add(this.BTConfirmar);
            this.Controls.Add(this.Passe);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.titulo_jogo_da_cobra);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label titulo_jogo_da_cobra;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox Passe;
        private System.Windows.Forms.Button BTConfirmar;
        private System.Windows.Forms.Button BTCancelar;
    }
}