using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dnd_4e_Character_Assistant.Classes
{
    class Cleric : CharacterClass
    {
        public Cleric() {
            WillBonus = 2;
            
            HpAtFirstLevel = 12;
            HpPerLevel = 5;
            BaseSurgesPerDay = 7;
        }
            
    }
}
