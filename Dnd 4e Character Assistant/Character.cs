using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dnd_4e_Character_Assistant.Persistance;
using Dnd_4e_Character_Assistant.Classes;

namespace Dnd_4e_Character_Assistant
{

    public class Ability {
        public int Score { get; set; }
        public int Mod { get {
            int temp = (Score % 2 == 0) ? Score : Score - 1;
            temp = temp / 2; //this puts us such that the scores are 0,1,2,3,4,5,6,7... for 0,2,4,6,8,10,12,14

            //0=-5
            //1=-4
            //2=-3
            //3=-2
            //4=-1
            //5= 0
            //6=+1
            //7=+2
            //8=+3
            //9=+4
            //10=+5
            //which is [mod = (temp -5)]
            int mod = temp - 5;
            return mod;
        } }
    
    }

    public class AbilityCollection {
        public AbilityCollection() {
            Strength = new Ability();
            Constitution = new Ability();
            Dexterity = new Ability();
            Inteligence = new Ability();
            Wisdom = new Ability();
            Charisma = new Ability();
        }

        public Ability Strength { get; private set; }
        public Ability Constitution { get; private set; }
        public Ability Dexterity { get; private set; }
        public Ability Inteligence { get; private set; }
        public Ability Wisdom { get; private set; }
        public Ability Charisma { get; private set; }
    }

    public class Level{
    public int Value { get; set; }
        public int Half{get{
        return Value/2; //TOOD: Unit test this
        }}
    }

    public class Health {
        public int MaxHP { get; set; }
        public int CurrentHP { get; set;}
        public int Bloodied { get { return MaxHP / 2; } }
        public int Surge { get { return Bloodied / 2; } }
        public int SurgesPerDay { get; set; }
    }

    public class Character
    {
        private ICharacterPersistance _persistance;



        public Character(ICharacterPersistance persistance)
        {
            _persistance = persistance;
            Load();
        }
        
        
        public AbilityCollection Abilities { get; set; }
        public Level Level{ get; set; }
        public CharacterClass Class { get; private set; }
        public Health Health { get; private set; }
        public CharacterRace Race { get; private set; }

        private void CalculateHealth() {
         int maxHp = Class.HpAtFirstLevel;
            maxHp += Abilities.Constitution.Score;
            for(int i = 1; i < Level.Value ;i++){
            maxHp += Class.HpPerLevel;
            }

            Health.MaxHP = maxHp;

            Health.SurgesPerDay = Class.BaseSurgesPerDay + Abilities.Constitution.Mod;

        }


        #region Save/Load Functions

        #region LoadFunctions
        private void Load()
        {
            Class = LoadClass();
            Race = LoadRace();
            LoadAbilities();
            LoadLevel();
            LoadHealth();
        }

        private CharacterClass LoadClass ()
		{
			string classString = _persistance.Get ("Class");

			if (classString == "Hybrid") {
				return Hybrid.Load(ref _persistance);
			}

            return CharacterClass.FromClassName(classString);
        }

        private CharacterRace LoadRace()
        {
            string raceString = _persistance.Get("Race");
            return CharacterRace.FromRaceName(raceString);
        }

        private void LoadAbilities()
        {
            Abilities = new AbilityCollection();
            Abilities.Strength.Score = int.Parse(_persistance.Get("Strength"));
            Abilities.Dexterity.Score = int.Parse(_persistance.Get("Dexterity"));
            Abilities.Constitution.Score = int.Parse(_persistance.Get("Constitution"));
            Abilities.Inteligence.Score = int.Parse(_persistance.Get("Inteligence"));
            Abilities.Wisdom.Score = int.Parse(_persistance.Get("Wisdom"));
            Abilities.Charisma.Score = int.Parse(_persistance.Get("Charisma"));
        }

        private void LoadLevel()
        {
            Level = new Level();
            Level.Value = int.Parse(_persistance.Get("Level"));
        }

        private void LoadHealth()
        {
            Health = new Health();
            Health.CurrentHP = int.Parse(_persistance.Get("CurrentHP"));

            //Determine our calculated values
            CalculateHealth();
        }
        #endregion

        #region SaveFunctions
        public void Save() {
            SaveClass();
            SaveRace();
            SaveAbilities();
            SaveLevel();
            SaveHealth();
        }

        private void SaveHealth()
        {
            _persistance.Set("CurrentHP", Health.CurrentHP.ToString());
        }

        private void SaveLevel()
        {
            _persistance.Set("Level", Level.Value.ToString());
        }

        private void SaveAbilities()
        {
            _persistance.Set("Strength", Abilities.Strength.Score.ToString());
            _persistance.Set("Dexterity", Abilities.Dexterity.Score.ToString());
            _persistance.Set("Constitution", Abilities.Constitution.Score.ToString());
            _persistance.Set("Inteligence", Abilities.Inteligence.Score.ToString());
            _persistance.Set("Wisdom", Abilities.Wisdom.Score.ToString());
            _persistance.Set("Charisma", Abilities.Charisma.Score.ToString());
        }

        private void SaveRace()
        {
            _persistance.Set("Race", Race.RaceName);
        }

        private void SaveClass()
        {
            _persistance.Set("Class", Class.ClassName);
            
        }
        #endregion

        #endregion


    }
}
