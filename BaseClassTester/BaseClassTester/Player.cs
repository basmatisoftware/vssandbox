using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClassTester
{
    public class Player:LivingCreature
    {
        public bool HasArmor;
        public int Level;
        public int Gold;

        public Player(string name, bool isAlive, int currentHP, bool hasArmor, int level, int gold) : base(name,  isAlive, currentHP)
        {
            Name = name;
            IsAlive = isAlive;
            CurrentHP = currentHP;
            HasArmor = hasArmor;
            Level = level;
            Gold = gold;
        }

    }
}
