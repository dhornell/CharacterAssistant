using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dnd_4e_Character_Assistant.Races
{
    class Human : CharacterRace
    {
        public Human()
        {

            ReflexBonus = 1;
            FortitudeBonus = 1;
            WillBonus = 1;

            Speed = 6;

            BonusAtWillPower = 1;

            Bonusfeats = 1;
            BonusSkill = 1;

        }

    }
}
