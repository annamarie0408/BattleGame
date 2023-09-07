using System;
using System.Collections.Generic;
using System.Text;

namespace BattleGame
{
    class _Warrior
    {
        public string _Name { get; set; } = "Warrior";
        public int _Health { get; set; } = 0;
        public int _MaxAttack { get; set; } = 0;
        public int _MaxBlock { get; set; } = 0;
        Random rnd = new Random();

        public _Warrior(string Name, int Health, int MaxAttack, int MaxBlock)
        {
            this._Name = Name;
            this._Health = Health;
            this._MaxAttack = MaxAttack;
            this._MaxAttack = MaxBlock;
        }

        public double Attack()
        {
            return rnd.Next(1, (int)_MaxAttack);
        }

        public double Block()
        {
            return rnd.Next(0, (int)_MaxAttack);
        }
    }
}
