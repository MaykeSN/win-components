using static WinComponents.Helpers.MoveBarHelper;
using System.Windows.Forms;
using System.Drawing;
using WinComponents.Themes;

namespace WinComponents
{
    public partial class NavBar: UserControl
    {
        private readonly ITheme _theme;
        public NavBar()
        {
            InitializeComponent();
            InitializeButtons();
            _theme = ThemeProvider.GetTheme();
            SetTheme();
        }
        private void SetTheme()
        {
            this.BackColor = _theme.AccentColor;
            LblTitle.ForeColor = _theme.TextColor;
        } 
        public string Title
        {
            get
            {
                return LblTitle.Text;
            }
            set
            {
                LblTitle.Text = $"{value.ToUpper()}";
            }
        }
        public Form FormControlled { get; set; }
        public Image Icon 
        { 
            get 
            { 
                return PicImage.Image; 
            } 
            set 
            {
                if(value != null)
                    PicImage.Image = value;
            } 
        }

        private void InitializeButtons()
        {
            BtnClose.Click += (s, e) => FormControlled.Close();
            BtnMaximizeWindow.Click += (s, e) =>
            {
                if (FormControlled.WindowState == FormWindowState.Normal)
                {
                    FormControlled.WindowState = FormWindowState.Maximized;
                    BtnMaximizeWindow.Image = Properties.Resources.minimize;
                }
                else
                {
                    FormControlled.WindowState = FormWindowState.Normal;
                    BtnMaximizeWindow.Image = Properties.Resources.maximize;

                }
            };
            BtnMinimizeWindow.Click += (s, e) => FormControlled.WindowState = FormWindowState.Minimized;
            LblTitle.MouseMove += (s, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    ReleaseCapture();
                    SendMessage(FormControlled.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                }
            };
        }

        public void HideMaximize()
        {
            BtnMaximizeWindow.Visible = false;
        }
    }
}
