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
            Random rand = new Random();
            int randomNr = rand.Next(0, 4);
            string[] name = new string[4] { "Rypherior",  "Charizard",  "Weedle",  "Squirtle"  };
            string[] type = new string[4] { "Ground", "Fire", "Grass", "Water" };
            switch (randomNr)
            {
                case 0: //Rypherior
                    string[] chargedAttackRy = new string[2] { "Earthquake", "Rock Wrecker" };
                    
                    
                    this.name = name[randomNr];
                    this.type = type[randomNr];
                    this.ChargedAttack = chargedAttackRy[rand.Next(0, 2)];
                    switch (chargedAttackRy[randomNr])
                    {
                        case "Earthquake":
                            this.ChargedAttackDamage = 140;
                            break;
                        case "Rock Wrecker":
                            this.ChargedAttackDamage = 110;
                            break;
                    }
                    this.Hp = rand.Next(119, 217);
                    this.AttackStrength = rand.Next(3, 16);
                    this.AttackChargedTo = 0;

                    break;
                case 1: //Charizard
                    string[] chargedAttackCh = new string[2] { "Earthquake", "Rock Wrecker" };


                    this.name = name[randomNr];
                    this.type = type[randomNr];
                    this.ChargedAttack = chargedAttackCh[rand.Next(0, 2)];
                    switch (chargedAttackCh[randomNr])
                    {
                        case "Earthquake":
                            this.ChargedAttackDamage = 140;
                            break;
                        case "Rock Wrecker":
                            this.ChargedAttackDamage = 110;
                            break;
                    }
                    this.Hp = rand.Next(119, 217);
                    this.AttackStrength = rand.Next(3, 16);
                    this.AttackChargedTo = 0;
                    break;
                case 2: //Weedle
                    string[] chargedAttackWe = new string[2] { "Struggle", "Return" };


                    this.name = name[randomNr];
                    this.type = type[randomNr];
                    this.ChargedAttack = chargedAttackWe[rand.Next(0, 2)];
                    switch (chargedAttackWe[randomNr])
                    {
                        case "Earthquake":
                            this.ChargedAttackDamage = 140;
                            break;
                        case "Rock Wrecker":
                            this.ChargedAttackDamage = 110;
                            break;
                    }
                    this.Hp = rand.Next(119, 217);
                    this.AttackStrength = rand.Next(3, 16);
                    this.AttackChargedTo = 0;
                    break;
                case 3: //Squirtle
                    string[] chargedAttackSq = new string[2] { "Water Pulse", "Aqua Jet" };


                    this.name = name[randomNr];
                    this.type = type[randomNr];
                    this.ChargedAttack = chargedAttackSq[rand.Next(0, 2)];
                    switch (chargedAttackSq[randomNr])
                    {
                        case "Earthquake":
                            this.ChargedAttackDamage = 140;
                            break;
                        case "Rock Wrecker":
                            this.ChargedAttackDamage = 110;
                            break;
                    }
                    this.Hp = rand.Next(119, 217);
                    this.AttackStrength = rand.Next(3, 16);
                    this.AttackChargedTo = 0;
                    break;
            }
        }
    }
}
