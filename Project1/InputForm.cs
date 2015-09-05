/*
 *  File: InputForm.cs
 *  Project: Introductory Project 1: Checks
 *  Primary Author: Geoffrey Cooley
 *  Contributing Team Members: Alex Will, Doug Hott, Joe Meyers
 *  Team Name: Djas
 *  Date Created: 8/30/2015
 *  Last Modified: 9/5/2015
 *  Description: The InputForm class provides users with an input interface for populating fields on a check.
 *               Once valid data is received, program execution is passed to the OutputForm interface class,
 *               where the InputProcessor and Tally classes pull data to populate their respective text fields
 *               on the check itself and the OutputForm class generates a image of the newly-created check.
 *               This file provides the functionality and input validation for the form specified in the 
 *               InputForm.Designer.cs file.
 *
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    //This partial class is also defined within InputForm.Designer.cs
    public partial class InputForm : Form
    {
        static string cName { get; set; }           //Store the "Pay To" input string
        static string cAmount { get; set; }         //Store the "Amount" input string
        static string cMemo { get; set; }           //Store the "Memo" input string
        static double cDoubleAmount { get; set; }   //Store the cAmount field as a double
        static int deciNum { get; set; }            //Store the number of decimal points in the "Amount" input string
        static bool validName { get; set; }         //Store whether the current "Pay To" input has been validated
        static bool validAmount { get; set; }       //Store whether the current "Amount" input has been validated
        static bool validMemo { get; set; }         //Store whether the current "Memo" input has been validated
        static string cDollarString { get; set; }   //Store the validated "Amount" as a string of words spelled out
        public static int cc = 0;                   //Initial check count
        public static int cn = 3002;                //Initial check number

        /*
         *  InputForm() constructor that allows for specifying check count and check number
         */
        public InputForm(int myCC, int myCN)
        {
            cc = myCC;
            cn = myCN;
            InitializeComponent();
            this.FormClosing += InputForm_FormClosing; //Subscribe this form's FormClosing property to the defined method, so if the InputForm is closed, the whole application will close.
        } //End InputForm(int, int) constructor

        /*
         *  InputForm() constructor that initializes the default form with no parameters passed.
         */
        public InputForm()
        {
            InitializeComponent();
            this.FormClosing += InputForm_FormClosing; //Subscribe this form's FormClosing property to the defined method, so if the InputForm is closed, the whole application will close.
        } //End InputForm() default constructor

        /*
         *  InputForm_FormClosing() method allows the exit of this form to close the entire app,
         *    rather than just close this form and keep the OutputForm running in the background.
         */
        private void InputForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        } //End InputForm_FormClosing() method

        /*  
         *  AddToCheckButton_Click() is the method that validates the user input and then store the input into three separate static strings.
         *  Upon method call, all static fields used for input validation are reset to their "empty" or "null" values.
         *  -First, the name text box is checked to determine whether or not anything was entered.
         *  -Second, the amount text box is checked to ensure a double was entered (or rather, a string that can be parsed into a double), then that amount string
         *    is ran through a check to determine if there is one (and only one) decimal point. If multiple decimal points are detected, an error message appears.
         *    If no decimals are detected, the string ".00" will be appended to the string then stored.
         *  -Last, the only validation ran on the Memo line is whether it exceeds a maximum value. Since the text box has a specified maximum, this check could possibly be removed.
         *  Once all fields are validated, execution of the program is passed to the OutputForm, which brings up a separate interface.
         *  Note that each field being validated has its own respective validate____Field() method call.
         */
        private void AddToCheckButton_Click(object sender, EventArgs e)
        {
            cName = "";
            cAmount = "";
            cMemo = "";
            cDoubleAmount = 0;
            deciNum = 0;
            validName = false;
            validAmount = false;
            validMemo = false;

            validName = validateNameField();
            validAmount = validateAmountField();
            validMemo = validateMemoField();

            Console.WriteLine("cName = " + cName + ", cAmount = " + cAmount + ", cMemo = " + cMemo);

            if (validName && validAmount && validMemo)
            {
                //causes error
                //cDollarString = InputProcessor.parseInput(cAmount);

                this.Hide();
                cc++; //increase the check count before starting the new form
                cn++; //increase the check number before starting the new form
                OutputForm oi = new OutputForm();
                oi.ShowDialog();
            }
        } // end AddToCheckButton_Click() method

        /*
         *  ClearButton_Click method simply clears the text box entries to their respective defaults.
         *  This method could be utilized to "cancel" a check before submitting it as well, by clearing the label fields on the check portion of the interface.
         */
        private void ClearButton_Click(object sender, EventArgs e)
        {
            NameTextBox.Text = "";
            NameErrorLabel.Visible = false;
            AmountTextBox.Text = "0.00";
            AmountErrorLabel.Visible = false;
            MemoTextBox.Text = "";
        } //End ClearButton_Click() method

        /*
         *  getName() method serves as an accessor for the cName field, used by the OutputForm.
         *  The default get and set did not work as intended, so this method was created.
         */
        public string getName() {
            return cName;
        } //End getName() method

        /*
         *  getDollar() method serves as an accessor for the cAmount field, used by the OutputForm and InputProcessor.
         *  The default get and set did not work as intended, so this method was created.
         */
        public string getDollar()
        {
            return cAmount;
        } //End getDollar() method

        /*
         *  getMemo() method serves as an accessor for the cMemo field, used by the OutputForm.
         *  The default get and set did not work as intended, so this method was created.
         */
        public string getMemo()
        {
            return cMemo;
        } //End getMemo() method

        /*
         *  validateNameField() method takes the user input for the "Pay To" field and ensures that the field is not blank.
         *  An additional check could be implemented to test against a max name size, but was not included in this version.
         *  Returns a boolean representing whether the Name field is valid.
         */
        public bool validateNameField()
        {
            bool isValid = true;
            if (NameTextBox.Text.Length == 0)
            {
                NameErrorLabel.Visible = true;
                return !isValid;
            }
            else
            {
                NameErrorLabel.Visible = false;
                cName = NameTextBox.Text;
                return isValid;
            }
        } //End validateNameField() method

        /*
         *  validateAmountField() method steps through the process of validating the amount string input by the user, prior to passing the string to the InputProcessor.
         *  First, a test is performed to determine if the input can be parsed as a double. If not, the appropriate error message is displayed. If the input can be parsed,
         *    any commas in the input are dealt with, and the number of decimal points are counted (in case of erroneous input). Based on the number of decimal points,
         *    we can determine whether no decimal values were input (deciNum == 0), one decimal point was input (desired case) or multiple digits were input (error message displayed).
         *  Within the code itself, the different cases that arise when a single decimal point is input are listed, and after a count of the number of digits following the decimal,
         *    a switch is performed on that value. Once the case is determined, the appropriate actions take place: append/concatenate necessary numeric text, hide/show error
         *    messages, and conversion to a double as a courtesy to Joe's Tally class :)  <-I don't think will be used in this version, as he handles the conversion in his class.
         *  Returns a boolean representing whether the Amount field is valid.
         */
        public bool validateAmountField()
        {
            bool isValid = true;
            double n;
            if (Double.TryParse(AmountTextBox.Text, out n))
            {
                Console.WriteLine("Double parsing successful!");
                Console.WriteLine("Here is the original string: " + AmountTextBox.Text);
                Console.WriteLine("Here is the parsed double: " + n.ToString());
                Console.WriteLine("Copying the AmountTextBox.Text to cAmount...");
                cAmount = AmountTextBox.Text.Replace(",", "");
                deciNum = AmountTextBox.Text.Split('.').Length - 1;  //Count the number of decimals in the Amount string
                Console.WriteLine("The raw cAmount value with any commas removed is: " + cAmount);
                Console.WriteLine("The number of decimals in the input string is: " + deciNum);
                if (deciNum == 0) //No decimal point within the input, will add ".00"
                {
                    AmountErrorLabel.Visible = false;
                    Console.WriteLine("Here is the current value of cAmount: " + cAmount);
                    cAmount = cAmount + ".00";
                    Console.WriteLine("Here is the updated value of cAmount: " + cAmount);
                    Double.TryParse(cAmount, out n);
                    cDoubleAmount = n;
                    Console.WriteLine("Here is the updated value of cDoubleAmount: " + cDoubleAmount);
                    return isValid;
                }
                else if (deciNum == 1)
                /*  
                 *  One decimal point within the input, possible options are: 
                 *          1. a decimal with no digits trailing;
                 *          2. a decimal with one digit trailing;
                 *          3. a decimal with two digits trailing;
                 *          4. a decimal with > 2 digits trailing
                 */
                {
                    //In order to determine the number of trailing digits, we will split the string by the decimal...
                    string[] amountParts = AmountTextBox.Text.Split('.');
                    Console.WriteLine("Here are the amountParts: ");
                    for (int i = 0; i < amountParts.Length; i++)
                    {
                        Console.Write(amountParts[i] + ", ");
                    }

                    if (amountParts[0] == "")
                    {
                        cAmount = String.Concat("0", cAmount);
                    }

                    //... and count the number of digits trailing the decimal point
                    int deciDigitCount = amountParts[1].Length;
                    Console.WriteLine("Here is the value of deciDigitCount: " + deciDigitCount);

                    switch (deciDigitCount) //Since delimiter characters are not included in the returned array elements, we must add the decimal for each case
                    {
                        case 0:         Console.WriteLine("Here is the current value of cAmount: " + cAmount);
                                        cAmount = cAmount + "00"; 
                                        Console.WriteLine("Here is the updated value of cAmount: " + cAmount);
                                        AmountErrorLabel.Visible = false;
                                        Double.TryParse(cAmount, out n);
                                        cDoubleAmount = n;
                                        Console.WriteLine("Here is the updated value of cDoubleAmount: " + cDoubleAmount);
                                        return isValid;

                        case 1:         Console.WriteLine("Here is the current value of cAmount: " + cAmount);
                                        cAmount = amountParts[0] + "." + amountParts[1] + "0";
                                        Console.WriteLine("Here is the updated value of cAmount: " + cAmount);
                                        AmountErrorLabel.Visible = false;
                                        Double.TryParse(cAmount, out n);
                                        cDoubleAmount = n;
                                        Console.WriteLine("Here is the updated value of cDoubleAmount: " + cDoubleAmount);
                                        return isValid;

                        case 2:         Console.WriteLine("This value of cAmount has the desired decimal places!");
                                        Console.WriteLine("Here is the current value of cAmount: " + cAmount);
                                        AmountErrorLabel.Visible = false;
                                        Double.TryParse(cAmount, out n);
                                        cDoubleAmount = n;
                                        Console.WriteLine("Here is the updated value of cDoubleAmount: " + cDoubleAmount);
                                        return isValid;

                        default:        Console.WriteLine("Here is the current value of cAmount: " + cAmount);
                                        Console.WriteLine("Since cAmount has too many decimal places, we will round it.");
                                        cAmount = Math.Round(n, 2).ToString("F");
                                        Console.WriteLine("Here is the updated value of cAmount: " + cAmount);
                                        AmountErrorLabel.Visible = false;
                                        Double.TryParse(cAmount, out n);
                                        cDoubleAmount = n;
                                        Console.WriteLine("Here is the updated value of cDoubleAmount: " + cDoubleAmount);
                                        return isValid;        
                    } //End of switch (deciDigitCount)
                }
                else //Within this else clause, the number of decimal points input was greater than 1 (or possibly less than zero I suppose)
                {
                    Console.WriteLine("The number of decimals is something other than 1 or 0.");
                    AmountErrorLabel.Visible = true;
                    return !isValid;
                } //End if-elseif (deciNum)
            } //End if (doubleParse successful)
            else
            {
                Console.WriteLine("Double parsing failed!");
                AmountErrorLabel.Visible = true;
                return !isValid;
            } //End else from (if (doubleParse successful))
        } //End validateAmountField() method

        /*
         *  validateMemoField() method simply checks whether the input is longer than 30 characters. Since the Memo line is an optional field on checks, no "null" validation
         *    is performed as in the validateNameField() method. Within the properties of the Memo Text Box, a maximum input value is specified which prohibits users from 
         *    exceeding a certain length, so really this method is unnecessary, but is still used in this version.
         *  Returns a boolean representing whether the Memo field is valid.
         */
        public bool validateMemoField()
        {
            bool isValid = true;
            if (MemoTextBox.Text.Length > 30)
            {
                MemoErrorLabel.Visible = true;
                return !isValid;
            } //End if (Memo too big)
            else
            {
                MemoErrorLabel.Visible = false;
                cMemo = MemoTextBox.Text;
                return isValid;
            } //End else from if (Memo too big)
        } //End validateMemoField() method

    } //End InputForm class definition
} //End Project1 namespace declaration
