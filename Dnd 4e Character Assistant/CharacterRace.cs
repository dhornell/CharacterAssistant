using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dnd_4e_Character_Assistant
{
    public class CharacterRace
    {
        #region static Collection
            public static CharacterRace Human { get { return new Dnd_4e_Character_Assistant.Races.Human(); } }
        #endregion

            public static CharacterRace FromRaceName(string raceName)
            {
                return (CharacterRace)Activator.CreateInstance(Type.GetType(string.Format("Dnd_4e_Character_Assistant.Races.{0}",raceName)));
            }
            public string RaceName
            {
                get
                {
                    return this.GetType().Name;
                }
            }



        public int ArmorClassBonus { get; protected set; }
        public int ReflexBonus { get; protected set; }
        public int FortitudeBonus { get; protected set; }
        public int WillBonus { get; protected set; }

        public int Speed { get; protected set; }

        public int BonusAtWillPower { get; protected set; }
        public int BonusEncounterPower { get; protected set; }
        public int BonusDailyPower { get; protected set; }

        public int Bonusfeats { get; protected set; }
        public int BonusSkill { get; protected set; }
    }
}
