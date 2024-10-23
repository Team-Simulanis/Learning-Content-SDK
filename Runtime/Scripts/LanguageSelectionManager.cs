namespace Simulanis.ContentSDK
{
    public class LanguageSelectionManager
    {
        private static string _currentLanguage = "English";

        // Property to get and set the current language
        public static string CurrentLanguage
        {
            get { return _currentLanguage; }
            set 
            { 
                _currentLanguage = value;//"English", "Hindi"   -  English is Default
            }
        }
    }
}
