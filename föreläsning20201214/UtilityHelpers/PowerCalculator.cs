using föreläsning20201214.MyPokemon;
using System;
using System.Collections.Generic;
using System.Text;

namespace föreläsning20201214.UtilityHelpers
{
    static class PowerCalculator
    {
        public static int PowerLevel(Pokemon pokemon)
        {
            int powerlevel = 0;
            if (pokemon.Type == "Charizard")
            {
                powerlevel = 10;
            }
            else if (pokemon.Type == "Bulbasaur")
            {
                powerlevel = 5;
            }
            else if (pokemon.Type == "Weepinbell")
            {
                powerlevel = 7;
            }

            return powerlevel;
        }
    }
}
