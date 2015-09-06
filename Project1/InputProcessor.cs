/*
 * Class Name:  InputProcessor.cs
 * Author:      Alex Will
 * Purpose:     To change the numerical amount that the user inputs into textual repersentation of the amount.
 * Methods:     parseInput accepts a string and splits the input on the decimal then calls the second method dollarToString which accepts an int. dollarToString takes the int and uses recursion to turn the int into its textual repersentation. dollarToString returns a string.
 *               parseInput takes the value returned from dollarToString and combines with the other variable in parseInput. parseInput then returns one string of the two values combined. 
 *
 */


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
            int leftDecimal = 0;
            if (dollarAmount == "")
            {
                leftDecimal = 0;
            }//end if
            else
            {
                 leftDecimal = int.Parse(dollarAmount);
            }//end else
            string rightDecimal = parsedUserInput[1];

            string intToString = dollarToString(leftDecimal);//send whole amount to recurse method

            fullConvertedAmount = intToString + " and " + rightDecimal + "/100"; //takes the returned value from dollarToString and makes the final string

            return fullConvertedAmount;
        }//end parseInput

        public static string dollarToString(int fullAmount)
        {
            string fullAmountString = "";



            

            string[] lessThanTwenty = { " zero", " one", " two", " three", " four", " five", " six", " seven", " eight", " nine", " ten", " eleven", " twelve", " thirteen", " fourteen", " fifteen", " sixteen", " seventeen", " eighteen", " nineteen" };
            string[] tensPlace = { " zero", " ten", " twenty", " thirty", " forty", " fifty", " sixty", " seventy", " eighty", " ninety" };
            string[] largerPlace = { " zero", " hundred", " thousand", " million" };

            if (fullAmount == 0)
            {
                return "zero";
            }//end if
            if ((fullAmount / 1000000) > 0)
            {
                fullAmountString += dollarToString(fullAmount / 1000000) + largerPlace[3]; //recurses to check for next amount;
                fullAmount = fullAmount % 1000000;
            }//end if
            if ((fullAmount / 1000) > 0)
            {
                fullAmountString += dollarToString(fullAmount / 1000) + largerPlace[2]; //recureses to check for hundreds and adds thousand;
                
                fullAmount = fullAmount % 1000;

            }//end if
            if ((fullAmount / 100) > 0)
            {
                fullAmountString += dollarToString(fullAmount / 100) + largerPlace[1]; // recures to check for ten and ones 
                fullAmount = fullAmount % 100;

            }//end if

            if (fullAmount > 0)
            {

                if (fullAmount < 20)
                {
                    fullAmountString += lessThanTwenty[fullAmount];

                }//end if
                else
                {
                    
                    fullAmountString += tensPlace[fullAmount / 10];
                    if ((fullAmount % 10) > 0)
                    {
                        fullAmountString += " " + lessThanTwenty[fullAmount % 10];
                    }//end if
                }//end else
            }//end if





            return fullAmountString;
        }//end dollarToString

    }
}
