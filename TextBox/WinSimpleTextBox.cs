using System.Windows.Forms;
using WinComponents.Themes;

namespace WinComponents.TextBox
{
    public partial class WinSimpleTextBox: UserControl
    {
        private readonly ITheme _theme;
        public string Text { get => TxtInput.Text; set { TxtInput.Text = value; } }
        public WinSimpleTextBox()
        {
            InitializeComponent();
            _theme = ThemeProvider.GetTheme();
            PnLine.BackColor = _theme.AccentColor;
        }

        private void TxtInput_KeyDown(object sender, KeyEventArgs e)
        {
            OnKeyDown(e);
        }
        public void Clear() => TxtInput.Clear();
        public void Focus() => TxtInput.Focus();
        public void ClearFocus() 
        {
            Clear();
            TxtInput.Enabled = true;
            Focus();
        }
    }
}
