﻿namespace WinComponents.TextBox
{
    partial class WinUserTextBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinUserTextBox));
            this.TxtInput = new System.Windows.Forms.TextBox();
            this.PnLine = new System.Windows.Forms.Panel();
            this.LblValidation = new System.Windows.Forms.Label();
            this.PicImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicImage)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtInput
            // 
            this.TxtInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtInput.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtInput.Location = new System.Drawing.Point(0, 0);
            this.TxtInput.Name = "TxtInput";
            this.TxtInput.Size = new System.Drawing.Size(350, 32);
            this.TxtInput.TabIndex = 12;
            this.TxtInput.TextChanged += new System.EventHandler(this.TxtInput_TextChanged);
            // 
            // PnLine
            // 
            this.PnLine.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PnLine.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnLine.Location = new System.Drawing.Point(0, 32);
            this.PnLine.Name = "PnLine";
            this.PnLine.Size = new System.Drawing.Size(380, 2);
            this.PnLine.TabIndex = 10;
            // 
            // LblValidation
            // 
            this.LblValidation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LblValidation.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblValidation.Location = new System.Drawing.Point(0, 34);
            this.LblValidation.Name = "LblValidation";
            this.LblValidation.Size = new System.Drawing.Size(380, 25);
            this.LblValidation.TabIndex = 11;
            // 
            // PicImage
            // 
            this.PicImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicImage.Dock = System.Windows.Forms.DockStyle.Right;
            this.PicImage.Image = ((System.Drawing.Image)(resources.GetObject("PicImage.Image")));
            this.PicImage.Location = new System.Drawing.Point(350, 0);
            this.PicImage.Name = "PicImage";
            this.PicImage.Size = new System.Drawing.Size(30, 32);
            this.PicImage.TabIndex = 13;
            this.PicImage.TabStop = false;
            // 
            // WinUserTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TxtInput);
            this.Controls.Add(this.PicImage);
            this.Controls.Add(this.PnLine);
            this.Controls.Add(this.LblValidation);
            this.Name = "WinUserTextBox";
            this.Size = new System.Drawing.Size(380, 59);
            ((System.ComponentModel.ISupportInitialize)(this.PicImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtInput;
        private System.Windows.Forms.PictureBox PicImage;
        private System.Windows.Forms.Panel PnLine;
        private System.Windows.Forms.Label LblValidation;
    }
}
