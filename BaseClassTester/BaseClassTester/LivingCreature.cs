using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClassTester
{
    public class LivingCreature
    {
        public string Name;
        public bool IsAlive;
        public int CurrentHP;

        public LivingCreature(string name, bool isAlive, int currentHP)
        {
            Name = name;
            IsAlive = isAlive;
            CurrentHP = currentHP;
        }

        public LivingCreature() { }
    }
}
