using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    static class InputProcessor
    {

        public static string parseInput(string userinput)
        {
            string fullConvertedAmount = "";

            string[] parsedUserInput = userinput.Split('.'); //splits the user into two seperate parts. The whole amount and decimal

            string dollarAmount = parsedUserInput[0];

            int leftDecimal = int.Parse(dollarAmount);
            string rightDecimal = parsedUserInput[1];

            string intToString = dollarToString(leftDecimal);

            fullConvertedAmount = intToString + " and " + rightDecimal + "/100";

            return fullConvertedAmount;
        }

        public static string dollarToString(int fullAmount)
        {
            string fullAmountString = "";



            Console.WriteLine("first" + fullAmount);

            string[] lessThanTwenty = { " zero", " one", " two", " three", " four", " five", " six", " seven", " eight", " nine", " ten", " eleven", " twelve", " thirteen", " fourteen", " fifteen", " seventeen", " eighteen", " nineteen" };
            string[] tensPlace = { " zero", " ten", " tewenty", " thirty", " forty", " fifty", " sixty", " sevnety", " eighty", " ninety" };
            string[] largerPlace = { " zero", " hundred", " thousand", " million" };

            if (fullAmount == 0)
            {
                return "zero";
            }
            if ((fullAmount / 1000000) > 0)
            {
                fullAmountString += dollarToString(fullAmount / 1000000) + largerPlace[3]; //recurses to check for next amount;
                fullAmount = fullAmount % 1000000;
            }
            if ((fullAmount / 1000) > 0)
            {
                fullAmountString += dollarToString(fullAmount / 1000) + largerPlace[2]; //recureses to check for hundreds and adds thousand;
                Console.WriteLine(fullAmount);
                fullAmount = fullAmount % 1000;
                Console.WriteLine("second:" + fullAmount);
            }
            if ((fullAmount / 100) > 0)
            {
                fullAmountString += dollarToString(fullAmount / 100) + largerPlace[1]; // recures to check for ten and ones 
                fullAmount = fullAmount % 100;
                Console.WriteLine("third" + fullAmount);
            }

            if (fullAmount > 0)
            {

                if (fullAmount < 20)
                {
                    fullAmountString += lessThanTwenty[fullAmount];
                    Console.WriteLine("fourth: " + fullAmount);
                }
                else
                {
                    Console.WriteLine("fifth: " + (fullAmount));
                    fullAmountString += tensPlace[fullAmount / 10];
                    if ((fullAmount % 10) > 0)
                    {
                        fullAmountString += " " + lessThanTwenty[fullAmount % 10];
                    }
                }
            }





            return fullAmountString;
        }

    }
}
