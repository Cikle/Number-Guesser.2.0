using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuesser2._0
{
    internal class Number
    {
        public int tries;
        public List<int> usedNumbers = new List<int>();
        // Help from Marek von Rogall
        public int checkInput(string userInput, int secretNumber)
        {
            try
            {
                int eingabe = int.Parse(userInput);


                if (eingabe < 1 || eingabe > 100)
                {
                    return 0;
                }

                usedNumbers.Add(eingabe);
                

                if (eingabe < secretNumber)
                {
                    tries++; return 1;

                }
                else if (eingabe > secretNumber)
                {
                    tries++; return 2;

                }
                else
                {
                    return 3;
                }
            }
            catch (FormatException)
            {
                return 4;
            }
        }
    }
}
