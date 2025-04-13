namespace WinComponents
{
    partial class NavBar
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

        #region Código gerado pelo Designer de Componentes

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NavBar));
            this.LblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnMinimizeWindow = new System.Windows.Forms.Button();
            this.BtnMaximizeWindow = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.PicImage = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicImage)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTitle
            // 
            this.LblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.ForeColor = System.Drawing.Color.White;
            this.LblTitle.Location = new System.Drawing.Point(50, 0);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(325, 55);
            this.LblTitle.TabIndex = 19;
            this.LblTitle.Text = "Title";
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnMinimizeWindow);
            this.panel1.Controls.Add(this.BtnMaximizeWindow);
            this.panel1.Controls.Add(this.BtnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(375, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 55);
            this.panel1.TabIndex = 17;
            // 
            // BtnMinimizeWindow
            // 
            this.BtnMinimizeWindow.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnMinimizeWindow.FlatAppearance.BorderSize = 0;
            this.BtnMinimizeWindow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnMinimizeWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimizeWindow.ForeColor = System.Drawing.Color.White;
            this.BtnMinimizeWindow.Location = new System.Drawing.Point(97, 0);
            this.BtnMinimizeWindow.Name = "BtnMinimizeWindow";
            this.BtnMinimizeWindow.Size = new System.Drawing.Size(40, 55);
            this.BtnMinimizeWindow.TabIndex = 10;
            this.BtnMinimizeWindow.Text = "___";
            this.BtnMinimizeWindow.UseVisualStyleBackColor = true;
            // 
            // BtnMaximizeWindow
            // 
            this.BtnMaximizeWindow.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnMaximizeWindow.FlatAppearance.BorderSize = 0;
            this.BtnMaximizeWindow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnMaximizeWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMaximizeWindow.Image = global::WinComponents.Properties.Resources.maximize;
            this.BtnMaximizeWindow.Location = new System.Drawing.Point(137, 0);
            this.BtnMaximizeWindow.Name = "BtnMaximizeWindow";
            this.BtnMaximizeWindow.Size = new System.Drawing.Size(47, 55);
            this.BtnMaximizeWindow.TabIndex = 11;
            this.BtnMaximizeWindow.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            this.BtnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.Image")));
            this.BtnClose.Location = new System.Drawing.Point(184, 0);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(45, 55);
            this.BtnClose.TabIndex = 12;
            this.BtnClose.UseVisualStyleBackColor = true;
            // 
            // PicImage
            // 
            this.PicImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.PicImage.Location = new System.Drawing.Point(0, 0);
            this.PicImage.Name = "PicImage";
            this.PicImage.Size = new System.Drawing.Size(50, 55);
            this.PicImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicImage.TabIndex = 18;
            this.PicImage.TabStop = false;
            // 
            // NavBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(60)))));
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PicImage);
            this.Name = "NavBar";
            this.Size = new System.Drawing.Size(604, 55);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnMinimizeWindow;
        private System.Windows.Forms.Button BtnMaximizeWindow;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.PictureBox PicImage;
    }
}
