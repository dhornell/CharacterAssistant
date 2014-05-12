using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dnd_4e_Character_Assistant.Persistance
{
    public interface ICharacterPersistance
    {
        string Get(string key);
        void Set(string key, string value);

    }
}
