using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckInterface
{
    class InputProccessor : Form1
    {

        public static string parseInput(string userinput)
        {
           string fullConvertedAmount = "";

            string[] parsedUserInput = userinput.Split('.'); //splits the user into two seperate parts. The whole amount and decimal
            
            string dollarAmount  = parsedUserInput[0].Replace(",","");

            int leftDecimal = int.Parse(dollarAmount);
            string rightDecimal = parsedUserInput[1];

            string intToString = dollarToString(leftDecimal);

            fullConvertedAmount = intToString + " and " + rightDecimal + "/100";

            return fullConvertedAmount;
        }

        public static string dollarToString(int fullAmount)
        {
            string fullAmountString = "";

            int dividedByMillion = fullAmount / 1000000;
            int dividedByThousand = fullAmount / 1000;
            int dividedByHundred = fullAmount / 100;
            int moduleTen = fullAmount % 10;

            string[] lessThanTwenty = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "seventeen", "eighteen", "nineteen" };
            string[] tensPlace = { "zero", "ten", "tewenty", "thirty", "forty", "fifty", "sixty", "sevnety", "eighty", "ninety"};
            string[] largerPlace = { "zero", " hundred", " thousand", " million" };

            if (fullAmount == 0)
            {
                return "zero";
            }
            else if(dividedByMillion > 0)
            {
                fullAmountString += dollarToString(dividedByMillion) + largerPlace[3]; //recurses to check for next amount;
                fullAmount = fullAmount % 1000000;
            }
            else if(dividedByThousand > 0)
            {
                fullAmountString += dollarToString(dividedByThousand) + largerPlace[2]; //recureses to check for hundreds and adds thousand;
                fullAmount = fullAmount % 1000;
            }
           else if(dividedByHundred > 0)
            {
                fullAmountString += dollarToString(dividedByHundred) + largerPlace[1]; // recures to check for ten and ones 
                fullAmount = fullAmount % 100;
            }

           if(fullAmount > 0)
            {
                if(fullAmountString != "")
                {
                    fullAmountString += " and ";
                }
                if (fullAmount < 20)
                {
                    fullAmountString += lessThanTwenty[fullAmount];
                }
                else
                {
                    fullAmountString += tensPlace[fullAmount / 10];
                    if ((moduleTen) > 0 )
                    {
                        fullAmountString += " " + lessThanTwenty[moduleTen];
                    }
                }
            }



            

            return fullAmountString;
        }

    }
}
