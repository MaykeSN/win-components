using System.Drawing;

namespace WinComponents.Themes
{
    public class LightTheme : ITheme
    {
        public Color BackgroundColor
        {
            get => Color.White;
        }
        public Color SecondaryColor 
        { 
            get => Color.FromArgb(240, 240, 240);
        }
        public Color TextColor
        {
            get => Color.White;
        }
        public Color SubTextColor
        {
            get => Color.FromArgb(117, 117, 117);
        }

        public Color AccentColor 
        {
            get => Color.FromArgb(40, 44, 60); 
        }

        public Color ErrorColor
        {
            get => Color.FromArgb(255, 63, 95);
        }

        public Color SuccessColor
        {
            get => Color.FromArgb(53, 158, 92);
        }
    }
}
