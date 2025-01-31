namespace Simulanis.ContentSDK
{
    /// <summary>
    /// Manages language selection across the SDK.
    /// </summary>
    public class LanguageSelectionManager
    {
        private static string _currentLanguage = null;

        /// <summary>
        /// Gets or sets the current language. Defaults to English.
        /// </summary>
        public static string CurrentLanguage
        {
            get { return _currentLanguage; }
            set 
            { 
                _currentLanguage = value;//"English", "Hindi"   -  Null is Default
            }
        }
    }
}
