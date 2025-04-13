using System;
using System.Windows.Forms;
using WinComponents.Themes;
using WinComponents.Abstractions;

namespace WinComponents.TextBox
{
    public partial class WinValidationTextBox: UserControl, IValidationComponent
    {
        private readonly ITheme _theme;
        public string Text { get => TxtInput.Text; set { TxtInput.Text = value; } }
        public int MaxLenght 
        { 
            get => TxtInput.MaxLength; 
            set 
            { 
                if(value < 0)
                    MaxLenght = value; 
            } 
        }
        public int MinLenght { get; set; }
        public string Contains { get; set; }
        public WinValidationTextBox()
        {
            InitializeComponent();
            _theme = ThemeProvider.GetTheme();
            SetTheme();
        }
        public void SetTheme()
        {
            PnLine.BackColor = _theme.AccentColor;
            this.BackColor = _theme.BackgroundColor;
            TxtInput.BackColor = _theme.BackgroundColor;
            LblValidation.ForeColor = _theme.SubTextColor;  
        }
        public void Clear() => TxtInput.Clear();
        public void Focus() => TxtInput.Focus();
        public void ClearFocus()
        {
            Clear();
            TxtInput.Enabled = true;
            Focus();
        }

        private void TxtInput_KeyDown(object sender, KeyEventArgs e)
        {
            OnKeyDown(e);
        }

        public void Error(string message) 
        {
            LblValidation.ForeColor = _theme.ErrorColor;
            LblValidation.Text = message;
            PnLine.BackColor = _theme.ErrorColor;
        }

        public void Success()
        {
            LblValidation.Text = "Campo válido";
            LblValidation.ForeColor = _theme.SuccessColor;
            PnLine.BackColor = _theme.SuccessColor;
        }

        public bool ValidateField() 
        {
            if (MinLenght != 0)
            {
                if (TxtInput.Text.Length < MinLenght)
                {
                    Error($"Mínimo de {MinLenght} caracteres");
                    return false;
                }
            }

            if (!string.IsNullOrEmpty(Contains))
            {
                if (!TxtInput.Text.Contains(Contains))
                {
                    Error($"O Texto precisa conter: ({Contains})");
                    return false;
                }
            }

            Success();
            return true;    
        }

        private void TxtInput_TextChanged(object sender, EventArgs e)
        {
            ValidateField();
        }
    }
}
