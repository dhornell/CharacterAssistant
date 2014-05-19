using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dnd_4e_Character_Assistant
{
    class Settings
    {
        public static string WorkingDirectory = MonoSupport.IsMono ? @"/home/dave/Dropbox/CharacterAssistant/" : @"C:\Users\Dave\Dropbox\CharacterAssistant\";
    }
}
