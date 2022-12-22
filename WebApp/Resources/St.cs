using System.Globalization;
using System.Resources;

namespace WebApp.Resources
{
    //Get's the localized strings from the resx files
    public static class St
    {
        public static CultureInfo currentCulture = CultureInfo.CreateSpecificCulture("en-US");

        public static ResourceManager localizer = new ResourceManager(typeof(St));


        public static void InitializeLocalization(string culture)
        {
            currentCulture = CultureInfo.CreateSpecificCulture(culture);
        }

        public static string r(string key)
        {
            return localizer.GetString(key, currentCulture);
        }
    }
}
