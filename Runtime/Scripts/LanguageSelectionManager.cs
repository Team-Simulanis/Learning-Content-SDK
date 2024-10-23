using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Simulanis.ContentSDK
{
    public class LanguageSelectionManager
    {
        private string _currentLanguage;

        // Property to get and set the current language
        public string CurrentLanguage
        {
            get { return _currentLanguage; }
            set 
            { 
                _currentLanguage = value;//"English", "Hindi"   -  English is Default
            }
        }
    }
}
