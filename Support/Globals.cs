using System.Configuration;

namespace SpecflowExcerciseSelenium.Support
{
    public static class Globals
    {
        public static string URL = ConfigurationManager.AppSettings["url"];
    }
}
