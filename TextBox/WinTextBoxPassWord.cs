using System;
using System.Windows.Forms;
using WinComponents.Themes;
using WinComponents.Abstractions;

namespace WinComponents.TextBox
{
    public partial class WinPasswordTextBox : UserControl, IValidationComponent
    {
        private readonly ITheme _theme;
        private bool _showPassword = false;
        public WinPasswordTextBox()
        {
            InitializeComponent();
            _theme = ThemeProvider.GetTheme();
            SetTheme();
        }

        public void SetTheme()
        {
            BackColor = _theme.BackgroundColor;
            PnLine.BackColor = _theme.AccentColor;
        }

        public bool ValidateField()
        {
            if (string.IsNullOrEmpty(TxtInput.Text))
            {
                Error("Campo obrigatório");
                return false;
            }

            Success();
            return true;
        }

        private void Error(string message)
        {
            LblValidation.Text = message;
            LblValidation.ForeColor = _theme.ErrorColor;
            PnLine.BackColor = _theme.ErrorColor;
        }

        private void Success()
        {
            LblValidation.Text = "Campo válido";
            LblValidation.ForeColor = _theme.SuccessColor;
            PnLine.BackColor = _theme.SuccessColor;
        }

        private void PicImage_Click(object sender, EventArgs e)
        {
            _showPassword = !_showPassword;
            if (_showPassword)
            {
                PicImage.Image = Properties.Resources.password_visible;
                TxtInput.PasswordChar = '\0';
            }
            else
            {
                PicImage.Image = Properties.Resources.password_invisible;
                TxtInput.PasswordChar = '*';
            }
        }

        private void TxtInput_TextChanged(object sender, EventArgs e)
        {
            ValidateField();
        }
    }
}
