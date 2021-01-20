
namespace TrunfoElementar
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.btnIniciar = new System.Windows.Forms.Button();
            this.picMenu = new System.Windows.Forms.PictureBox();
            this.btnRegras = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.Black;
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.Color.White;
            this.btnIniciar.Location = new System.Drawing.Point(80, 273);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(240, 29);
            this.btnIniciar.TabIndex = 16;
            this.btnIniciar.Text = "&Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // picMenu
            // 
            this.picMenu.BackColor = System.Drawing.Color.Transparent;
            this.picMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picMenu.BackgroundImage")));
            this.picMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picMenu.Location = new System.Drawing.Point(80, 27);
            this.picMenu.Name = "picMenu";
            this.picMenu.Size = new System.Drawing.Size(240, 240);
            this.picMenu.TabIndex = 15;
            this.picMenu.TabStop = false;
            // 
            // btnRegras
            // 
            this.btnRegras.BackColor = System.Drawing.Color.Black;
            this.btnRegras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegras.ForeColor = System.Drawing.Color.White;
            this.btnRegras.Location = new System.Drawing.Point(80, 308);
            this.btnRegras.Name = "btnRegras";
            this.btnRegras.Size = new System.Drawing.Size(240, 29);
            this.btnRegras.TabIndex = 17;
            this.btnRegras.Text = "&Regras";
            this.btnRegras.UseVisualStyleBackColor = false;
            this.btnRegras.Click += new System.EventHandler(this.btnRegras_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Black;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(80, 343);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(240, 29);
            this.btnSair.TabIndex = 18;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(400, 401);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnRegras);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.picMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trunfo Elementar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMenu_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.PictureBox picMenu;
        private System.Windows.Forms.Button btnRegras;
        private System.Windows.Forms.Button btnSair;
    }
}