using System;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathFinderCharacterCreator
{
    class Character
    {
        private int _strength;
        private int _dexterity;
        private int _constitution;
        private int _inteligence;
        private int _wisdom;
        private int _charisma;

        public int Strength { get => _strength; set => _strength = value; }
        public int Dexterity { get => _dexterity; set => _dexterity = value; }
        public int Constitution { get => _constitution; set => _constitution = value; }
        public int Inteligence { get => _inteligence; set => _inteligence = value; }
        public int Wisdom { get => _wisdom; set => _wisdom = value; }
        public int Charisma { get => _charisma; set => _charisma = value; }

        public int CalculateAbilityModifier(int abilityScore)
        {
            return (abilityScore-10)/2;
        }
    }
}
