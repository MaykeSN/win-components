namespace WinComponents.TextBox
{
    partial class WinValidationTextBox
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
            this.TxtInput = new System.Windows.Forms.TextBox();
            this.PnLine = new System.Windows.Forms.Panel();
            this.LblValidation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtInput
            // 
            this.TxtInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtInput.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtInput.Location = new System.Drawing.Point(0, 0);
            this.TxtInput.Name = "TxtInput";
            this.TxtInput.Size = new System.Drawing.Size(380, 32);
            this.TxtInput.TabIndex = 3;
            this.TxtInput.TextChanged += new System.EventHandler(this.TxtInput_TextChanged);
            this.TxtInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtInput_KeyDown);
            // 
            // PnLine
            // 
            this.PnLine.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PnLine.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnLine.Location = new System.Drawing.Point(0, 32);
            this.PnLine.Name = "PnLine";
            this.PnLine.Size = new System.Drawing.Size(380, 2);
            this.PnLine.TabIndex = 2;
            // 
            // LblValidation
            // 
            this.LblValidation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblValidation.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblValidation.Location = new System.Drawing.Point(0, 34);
            this.LblValidation.Name = "LblValidation";
            this.LblValidation.Size = new System.Drawing.Size(380, 25);
            this.LblValidation.TabIndex = 4;
            // 
            // WinValidationTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LblValidation);
            this.Controls.Add(this.PnLine);
            this.Controls.Add(this.TxtInput);
            this.Name = "WinValidationTextBox";
            this.Size = new System.Drawing.Size(380, 59);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtInput;
        private System.Windows.Forms.Panel PnLine;
        private System.Windows.Forms.Label LblValidation;
    }
}
