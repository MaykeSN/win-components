using System.Drawing;

namespace WinComponents.Themes
{
    public interface ITheme
    {
        Color BackgroundColor { get; }
        Color SecondaryColor { get;}
        Color TextColor { get; }
        Color AccentColor { get; }
        Color SubTextColor { get;  }
        Color ErrorColor { get; }
        Color SuccessColor { get; }
    }
}
