using föreläsning20201214.MyPokemon;
using föreläsning20201214.UtilityHelpers;
using System;
using System.Collections.Generic;

namespace föreläsning20201214
{
    class Program
    {
            static List<Pokemon> listOfPokemons = new List<Pokemon>();
        static void Main(string[] args)
        {
            /*
             --------------------------------------------------------
                                POKEMON!!!!
             --------------------------------------------------------
             
            
            Best practice när det gäller Private, Public, Abstrakt, Static m.m

            
            1. Namngivning - Använd camelCase på variabler
                         - Använd PascalCase för metoder och klasser

            2. Använd endast en klass per fil!
            3. Private first tänk. Använd private när det inte behöver vara public
            4. Metoder ska utföra EN sak
            5. Static, använd endast utilitys. Keep it simple

             */


            SetupSampleData();

            Console.ReadKey();
        }

       

        private static void SetupSampleData()
        {
            
            listOfPokemons.Add(new Pokemon() { Name = "Charizard", Type = "Fire" });
            listOfPokemons.Add(new Pokemon() { Name = "Tyranitar", Type = "Rock" });

        }

        

        
    }
}
