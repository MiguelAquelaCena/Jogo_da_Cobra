namespace Jogo_da_cobra
{
    partial class Jogo_da_cobra
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Jogo_da_cobra));
            this.titulo_jogo_da_cobra = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BTjogar = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslAutor = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslData = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // titulo_jogo_da_cobra
            // 
            this.titulo_jogo_da_cobra.AutoSize = true;
            this.titulo_jogo_da_cobra.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo_jogo_da_cobra.ForeColor = System.Drawing.Color.Lime;
            this.titulo_jogo_da_cobra.Location = new System.Drawing.Point(111, 30);
            this.titulo_jogo_da_cobra.Name = "titulo_jogo_da_cobra";
            this.titulo_jogo_da_cobra.Size = new System.Drawing.Size(397, 80);
            this.titulo_jogo_da_cobra.TabIndex = 0;
            this.titulo_jogo_da_cobra.Text = "Jogo da Cobra";
            this.titulo_jogo_da_cobra.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BTjogar
            // 
            this.BTjogar.FlatAppearance.BorderSize = 0;
            this.BTjogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTjogar.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTjogar.ForeColor = System.Drawing.Color.Lime;
            this.BTjogar.Location = new System.Drawing.Point(169, 122);
            this.BTjogar.Name = "BTjogar";
            this.BTjogar.Size = new System.Drawing.Size(299, 147);
            this.BTjogar.TabIndex = 2;
            this.BTjogar.Text = "Jogar";
            this.BTjogar.UseVisualStyleBackColor = true;
            this.BTjogar.Click += new System.EventHandler(this.button1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslAutor,
            this.tslData,
            this.tslHora,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tslAutor
            // 
            this.tslAutor.Name = "tslAutor";
            this.tslAutor.Size = new System.Drawing.Size(49, 17);
            this.tslAutor.Text = "tslAutor";
            // 
            // tslData
            // 
            this.tslData.Name = "tslData";
            this.tslData.Size = new System.Drawing.Size(43, 17);
            this.tslData.Text = "tslData";
            // 
            // tslHora
            // 
            this.tslHora.Name = "tslHora";
            this.tslHora.Size = new System.Drawing.Size(45, 17);
            this.tslHora.Text = "tslHora";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Jogo_da_cobra.Properties.Resources.kisspng_snakes_and_ladders_game_android_clip_art_animated_snake_pictures_5a7c988485b4d1_8632212215181149485477;
            this.pictureBox1.Location = new System.Drawing.Point(550, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 254);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // Jogo_da_cobra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.BTjogar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.titulo_jogo_da_cobra);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Jogo_da_cobra";
            this.Text = "Jogo da Cobra";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titulo_jogo_da_cobra;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button BTjogar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslAutor;
        private System.Windows.Forms.ToolStripStatusLabel tslData;
        private System.Windows.Forms.ToolStripStatusLabel tslHora;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
    }
}

