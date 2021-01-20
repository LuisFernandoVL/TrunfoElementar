
namespace TrunfoElementar
{
    partial class frmSplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplashScreen));
            this.lblNomeJogo = new System.Windows.Forms.Label();
            this.picSplashScreen = new System.Windows.Forms.PictureBox();
            this.tmrSplashScreen = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picSplashScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomeJogo
            // 
            this.lblNomeJogo.AutoSize = true;
            this.lblNomeJogo.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeJogo.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeJogo.Location = new System.Drawing.Point(48, 300);
            this.lblNomeJogo.Name = "lblNomeJogo";
            this.lblNomeJogo.Size = new System.Drawing.Size(313, 57);
            this.lblNomeJogo.TabIndex = 3;
            this.lblNomeJogo.Text = "Trunfo Elementar";
            // 
            // picSplashScreen
            // 
            this.picSplashScreen.BackColor = System.Drawing.Color.Transparent;
            this.picSplashScreen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picSplashScreen.BackgroundImage")));
            this.picSplashScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picSplashScreen.Location = new System.Drawing.Point(80, 57);
            this.picSplashScreen.Name = "picSplashScreen";
            this.picSplashScreen.Size = new System.Drawing.Size(240, 240);
            this.picSplashScreen.TabIndex = 2;
            this.picSplashScreen.TabStop = false;
            // 
            // tmrSplashScreen
            // 
            this.tmrSplashScreen.Interval = 3000;
            this.tmrSplashScreen.Tick += new System.EventHandler(this.tmrSplashScreen_Tick);
            // 
            // frmSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.lblNomeJogo);
            this.Controls.Add(this.picSplashScreen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trunfo Elementar";
            this.Load += new System.EventHandler(this.frmSplashScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSplashScreen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeJogo;
        private System.Windows.Forms.PictureBox picSplashScreen;
        private System.Windows.Forms.Timer tmrSplashScreen;
    }
}

