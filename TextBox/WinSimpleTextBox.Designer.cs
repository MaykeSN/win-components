namespace WinComponents.TextBox
{
    partial class WinSimpleTextBox
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
            this.PnLine = new System.Windows.Forms.Panel();
            this.TxtInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // PnLine
            // 
            this.PnLine.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PnLine.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnLine.Location = new System.Drawing.Point(0, 32);
            this.PnLine.Name = "PnLine";
            this.PnLine.Size = new System.Drawing.Size(502, 2);
            this.PnLine.TabIndex = 0;
            // 
            // TxtInput
            // 
            this.TxtInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtInput.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtInput.Location = new System.Drawing.Point(0, 0);
            this.TxtInput.Name = "TxtInput";
            this.TxtInput.Size = new System.Drawing.Size(502, 32);
            this.TxtInput.TabIndex = 1;
            this.TxtInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtInput_KeyDown);
            // 
            // WinSimpleTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TxtInput);
            this.Controls.Add(this.PnLine);
            this.Name = "WinSimpleTextBox";
            this.Size = new System.Drawing.Size(502, 34);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnLine;
        private System.Windows.Forms.TextBox TxtInput;
    }
}
