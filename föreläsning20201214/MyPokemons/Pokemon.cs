using System;
using System.Collections.Generic;
using System.Text;

namespace föreläsning20201214.MyPokemon
{
    class Pokemon
    {
        private string name;
        private string type;
        private int hp;
        private int cp;
        private string chargedAttack;
        private int attackChargedTo;
        private int chargedAttackDamage;

        public string Name { get => name; set => name = value; }
        public string Type { get => type; set => type = value; }
        public int Hp { get => hp; set => hp = value; }
        public int AttackStrength { get => cp; set => cp = value; }
        public string ChargedAttack { get => chargedAttack; set => chargedAttack = value; }
        public int AttackChargedTo { get => attackChargedTo; set => attackChargedTo = value; }
        public int ChargedAttackDamage { get => chargedAttackDamage; set => chargedAttackDamage = value; }

        public Pokemon()
        {

        }
    }
}
