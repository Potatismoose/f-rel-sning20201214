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
        private int attackStrength;
        private string chargedAttack;
        private int attackChargedTo;
        private int chargedAttackDamage;

        public string Name { get => name; set => name = value; }
        public string Type { get => type; set => type = value; }
        public int Hp { get => hp; set => hp = value; }
        public int AttackStrength { get => attackStrength; set => attackStrength = value; }
        public int Cp { get => cp; set => cp = value; }
        public string ChargedAttack { get => chargedAttack; set => chargedAttack = value; }
        public int AttackChargedTo { get => attackChargedTo; set => attackChargedTo = value; }
        public int ChargedAttackDamage { get => chargedAttackDamage; set => chargedAttackDamage = value; }

        public Pokemon()
        {
            Random rand = new Random();
            int randomNr = rand.Next(0, 4);
            string[] name = new string[4] { "Rypherior", "Charizard", "Weedle", "Squirtle" };
            string[] type = new string[4] { "Ground", "Fire", "Grass", "Water" };
            switch (randomNr)
            {
                case 0: //Rypherior
                    string[] chargedAttackRy = new string[2] { "Earthquake", "Rock Wrecker" };

                    this.Name = name[randomNr];
                    this.Type = type[randomNr];
                    randomNr = rand.Next(0, 2);
                    this.ChargedAttack = chargedAttackRy[randomNr];
                    switch (chargedAttackRy[randomNr])
                    {
                        case "Earthquake":
                            this.ChargedAttackDamage = 140;
                            break;
                        case "Rock Wrecker":
                            this.ChargedAttackDamage = 110;
                            break;
                    }
                    CalculateCpAndMore();
                    this.AttackChargedTo = 0;
                    break;

                case 1: //Charizard
                    string[] chargedAttackCh = new string[2] { "Frustration", "Overheat" };

                    this.Name = name[randomNr];
                    this.Type = type[randomNr];
                    randomNr = rand.Next(0, 2);
                    this.ChargedAttack = chargedAttackCh[randomNr];
                    switch (chargedAttackCh[randomNr])
                    {
                        case "Frustration":
                            this.ChargedAttackDamage = 10;
                            break;
                        case "Overheat":
                            this.ChargedAttackDamage = 160;
                            break;
                    }
                    CalculateCpAndMore();
                    this.AttackChargedTo = 0;
                    break;

                case 2: //Weedle
                    string[] chargedAttackWe = new string[2] { "Struggle", "Return" };

                    this.Name = name[randomNr];
                    this.Type = type[randomNr];
                    randomNr = rand.Next(0, 2);
                    this.ChargedAttack = chargedAttackWe[randomNr];
                    switch (chargedAttackWe[randomNr])
                    {
                        case "Struggle":
                            this.ChargedAttackDamage = 35;
                            break;
                        case "Return":
                            this.ChargedAttackDamage = 35;
                            break;
                    }
                    CalculateCpAndMore();
                    this.AttackChargedTo = 0;
                    break;

                case 3: //Squirtle
                    string[] chargedAttackSq = new string[2] { "Water Pulse", "Aqua Jet" };

                    this.Name = name[randomNr];
                    this.Type = type[randomNr];
                    randomNr = rand.Next(0, 2);
                    this.ChargedAttack = chargedAttackSq[randomNr];
                    switch (chargedAttackSq[randomNr])
                    {
                        case "Water Pulse":
                            this.ChargedAttackDamage = 70;
                            break;
                        case "Aqua Jet":
                            this.ChargedAttackDamage = 45;
                            break;
                    }
                    CalculateCpAndMore();
                    this.AttackChargedTo = 0;
                    break;
            }
        }

        private void CalculateCpAndMore()
        {
            Random rand = new Random();
            int randomNr;
            this.Hp = rand.Next(119, 217);
            randomNr = rand.Next(600, 3074);
            this.Cp = randomNr;
            if (Cp >= 600 && cp < 1000)
            {
                this.AttackStrength = rand.Next(3, 8);
                this.Hp = rand.Next(60,100);
            }
            else if (Cp >= 1000 && cp < 2000)
            {
                this.AttackStrength = rand.Next(5, 10);
                this.Hp = rand.Next(100,130);
            }
            else if (Cp >= 2000 && cp < 2500)
            {
                this.AttackStrength = rand.Next(7, 13);
                this.Hp = rand.Next(130,160);
            }
            else if (Cp >= 2500)
            {
                this.AttackStrength = rand.Next(9, 16);
                this.Hp = rand.Next(160,217);
            }
        }

        //TODO Göra klart CalculateHp
        public int CalculateHp(int damageDealt)
        {
            int lostHp = default(int);


            return lostHp;
        }
    }
}
