namespace Jogo_da_cobra
{
    partial class Formexp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formexp));
            this.timerJogo = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.TsNivel = new System.Windows.Forms.ToolStripStatusLabel();
            this.TsPontos = new System.Windows.Forms.ToolStripStatusLabel();
            this.TsJogar = new System.Windows.Forms.ToolStripDropDownButton();
            this.TsSair = new System.Windows.Forms.ToolStripDropDownButton();
            this.TsPausa = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerJogo
            // 
            this.timerJogo.Tick += new System.EventHandler(this.timerJogo_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsNivel,
            this.TsPontos,
            this.TsJogar,
            this.TsSair,
            this.TsPausa,
            this.tsHora});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // TsNivel
            // 
            this.TsNivel.Name = "TsNivel";
            this.TsNivel.Size = new System.Drawing.Size(44, 17);
            this.TsNivel.Text = "TsNivel";
            // 
            // TsPontos
            // 
            this.TsPontos.Name = "TsPontos";
            this.TsPontos.Size = new System.Drawing.Size(54, 17);
            this.TsPontos.Text = "TsPontos";
            // 
            // TsJogar
            // 
            this.TsJogar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TsJogar.Image = ((System.Drawing.Image)(resources.GetObject("TsJogar.Image")));
            this.TsJogar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsJogar.Name = "TsJogar";
            this.TsJogar.Size = new System.Drawing.Size(58, 20);
            this.TsJogar.Text = "TsJogar";
            // 
            // TsSair
            // 
            this.TsSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TsSair.Image = ((System.Drawing.Image)(resources.GetObject("TsSair.Image")));
            this.TsSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsSair.Name = "TsSair";
            this.TsSair.Size = new System.Drawing.Size(49, 20);
            this.TsSair.Text = "TsSair";
            // 
            // TsPausa
            // 
            this.TsPausa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TsPausa.Image = ((System.Drawing.Image)(resources.GetObject("TsPausa.Image")));
            this.TsPausa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsPausa.Name = "TsPausa";
            this.TsPausa.Size = new System.Drawing.Size(61, 20);
            this.TsPausa.Text = "TsPausa";
            // 
            // tsHora
            // 
            this.tsHora.Name = "tsHora";
            this.tsHora.Size = new System.Drawing.Size(42, 17);
            this.tsHora.Text = "tsHora";
            // 
            // Formexp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Formexp";
            this.Text = "Formexp";
            this.Load += new System.EventHandler(this.Formexp_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Formexp_Paint);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Formexp_KeyPress);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerJogo;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel TsNivel;
        private System.Windows.Forms.ToolStripStatusLabel TsPontos;
        private System.Windows.Forms.ToolStripDropDownButton TsJogar;
        private System.Windows.Forms.ToolStripDropDownButton TsSair;
        private System.Windows.Forms.ToolStripDropDownButton TsPausa;
        private System.Windows.Forms.ToolStripStatusLabel tsHora;
    }
}