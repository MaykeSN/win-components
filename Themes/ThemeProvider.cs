using System;
using System.Linq;
using System.Reflection;

namespace WinComponents.Themes
{
    public static class ThemeProvider
    {
        public static ITheme GetTheme()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();

            var themeProvider = assembly.GetTypes()
                .FirstOrDefault(t => t.GetInterfaces().Contains(typeof(IThemeProvider)) && t.IsClass);

            if (themeProvider is null)
            {
                return new LightTheme();
            }

            return themeProvider.GetMethod("GetTheme").Invoke(Activator.CreateInstance(themeProvider), null) as ITheme;
        }
    }
}
