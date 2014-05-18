using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dnd_4e_Character_Assistant.Feats;

namespace Dnd_4e_Character_Assistant
{
    #region Defenses
    abstract class Defense{
        protected Character Character { get; private set; }
        public Defense(ref Character c) { Character = c; }
        public int Value { get { return (10 +Mod); } }
        public abstract int Mod { get; }
		public abstract int FeatBonus{get;}
		//public abstract int EnchantmentBonus{get;}
    }

    class ArmorClassDefense : Defense {
        public ArmorClassDefense(ref Character c) : base(ref c) { }
        public override int Mod
        {
            get {
                int halfLevel = Character.Level.Half;
                int armorBonus = 0/*Character.Armor*/;
                int dexBonus = Character.Abilities.Dexterity.Mod;
                int classBonus = Character.Class.ArmorClassBonus;
                int featBonus = FeatBonus/*Character.Feats*//*Itterate through them*/;
                int enchantBonus = 0/*Character.Enchantments*//*Itter through them*/;
                int racialBonus = Character.Race.ArmorClassBonus;
                int misc = 0/*???*/;

                return halfLevel + (/*hasArmor*/false ? armorBonus : dexBonus) + classBonus + featBonus + enchantBonus + racialBonus + misc;
            }
        }

		public override int FeatBonus {
			get {
				int bonus = 0;
				foreach(Feat f in Character.Feats){
					bonus+=f.ArmorClassBonus;
				}
				return bonus;
			}
		}

    }

    class FortitudeDefense : Defense {
        public FortitudeDefense(ref Character c) : base(ref c) { }
        public override int Mod
        {
            get {
                int halfLevel = Character.Level.Half;
                int abilBonus = Math.Max(Character.Abilities.Strength.Mod, Character.Abilities.Constitution.Mod);
                int classBonus = Character.Class.FortitudeBonus;
                int featBonus = FeatBonus/*Character.Feats*//*Itterate through them*/;
                int enchantBonus = 0/*Character.Enchantments*//*Itter through them*/;
                int racialBonus = Character.Race.FortitudeBonus;
                int misc = 0/*???*/;

                return halfLevel + abilBonus + classBonus + featBonus + enchantBonus + racialBonus + misc;
            
            }
        }

		public override int FeatBonus {
			get {
				int bonus = 0;
				foreach(Feat f in Character.Feats){
					bonus+=f.FortitudeBonus;
				}
				return bonus;
			}
		}
    }

    class ReflexDefense : Defense
    {
        public ReflexDefense(ref Character c) : base(ref c) { }
        public override int Mod
        {
            get {
                int halfLevel = Character.Level.Half;
                int abilBonus = Math.Max(Character.Abilities.Dexterity.Mod, Character.Abilities.Inteligence.Mod);
                int classBonus = Character.Class.ReflexBonus;
                int featBonus = FeatBonus/*Character.Feats*//*Itterate through them*/;
                int enchantBonus = 0/*Character.Enchantments*//*Itter through them*/;
                int racialBonus = Character.Race.ReflexBonus;
                int misc = 0/*???*/;

                return halfLevel + abilBonus + classBonus + featBonus + enchantBonus + racialBonus + misc;
            }
        }

		public override int FeatBonus {
			get {
				int bonus = 0;
				foreach(Feat f in Character.Feats){
					bonus+=f.ReflexBonus;
				}
				return bonus;
			}
		}
    }

    class WillDefense : Defense
    {
        public WillDefense(ref Character c) : base(ref c) { }
        public override int Mod
        {
            get {
                int halfLevel = Character.Level.Half;
                int abilBonus = Math.Max(Character.Abilities.Wisdom.Mod, Character.Abilities.Charisma.Mod);
                int classBonus = Character.Class.WillBonus;
                int featBonus = FeatBonus/*Character.Feats*//*Itterate through them*/;
                int enchantBonus = 0/*Character.Enchantments*//*Itter through them*/;
                int racialBonus = Character.Race.WillBonus;
                int misc = 0/*???*/;

                return halfLevel + abilBonus + classBonus + featBonus + enchantBonus +racialBonus + misc;
            }
        }

		public override int FeatBonus {
			get {
				int bonus = 0;
				foreach(Feat f in Character.Feats){
					bonus+=f.WillBonus;
				}
				return bonus;
			}
		}
    }

    class DefenseCollection{
        public DefenseCollection(ref Character c){
            ArmorClass = new ArmorClassDefense(ref c);
            Fortitude = new FortitudeDefense(ref c);
            Reflex = new ReflexDefense(ref c);
            Wisdom = new WillDefense(ref c);
        }

        public Defense ArmorClass { get; set; }
        public Defense Fortitude { get; set; }
        public Defense Reflex { get; set; }
        public Defense Wisdom { get; set; }

    }
    #endregion

    class CharacterSheet
    {
        public CharacterSheet(ref Character character){
            Defenses = new DefenseCollection(ref character);
        }

        public DefenseCollection Defenses { get;private set; }
    }
}
