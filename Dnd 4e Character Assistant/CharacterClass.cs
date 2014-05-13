using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;


namespace Dnd_4e_Character_Assistant
{
	public enum SaveBonusType{Fortitude,Reflex,Will,None};


    public class CharacterClass
    {
        #region static Collection
        public static CharacterClass Cleric { get { return new Dnd_4e_Character_Assistant.Classes.Cleric(); } }

        #endregion

        public static CharacterClass FromClassName(string className) {

            return (CharacterClass)Activator.CreateInstance(Type.GetType(string.Format("Dnd_4e_Character_Assistant.Classes.{0}",className)));
        }
        public string ClassName { get {
            return this.GetType().Name;
        } }


        #region DefenseBonus
        public int FortitudeBonus {get; protected set;}
        public int ReflexBonus { get; protected set; }
        public int WillBonus { get; protected set; }
        public int ArmorClassBonus { get; protected set; }
        #endregion

        #region Health
        public int HpAtFirstLevel { get; protected set; }
        public int HpPerLevel { get; protected set; }
        public int BaseSurgesPerDay { get; protected set; }
        #endregion


    }
}
