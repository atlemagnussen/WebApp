using System.Globalization;
using System.Resources;

namespace WebApp.Resources
{
    public static class St
    {
        public static CultureInfo currentCulture = CultureInfo.CreateSpecificCulture("en-US");

        public static ResourceManager localizer = new ResourceManager(typeof(St));


        public static void InitializeLocalization(string culture)
        {
            currentCulture = CultureInfo.CreateSpecificCulture(culture);

            localizer.GetString("home", currentCulture);
        }

        public static string r(string key)
        {
            return localizer.GetString(key, currentCulture);
        }
    }
}
