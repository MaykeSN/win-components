using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinComponents.Themes;
using WinComponents.Abstractions;

namespace WinComponents.TextBox
{
    public partial class WinUserTextBox: UserControl, IValidationComponent
    {
        public WinUserTextBox()
        {
            InitializeComponent();
            _theme = ThemeProvider.GetTheme();
            SetTheme();
        }

        private readonly ITheme _theme;

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

        private void TxtInput_TextChanged(object sender, EventArgs e)
        {
            ValidateField();
        }
    }
}
