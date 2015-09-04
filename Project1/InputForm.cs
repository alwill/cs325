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
    public partial class InputForm : Form
    {
        static string cName { get; set; }
        static string cAmount { get; set; }
        static string cMemo { get; set; }
        static double cDoubleAmount { get; set; }
        static int deciNum { get; set; }
        static bool validName { get; set; }
        static bool validAmount { get; set; }
        static bool validMemo { get; set; }
        static string cDollarString { get; set; }
        //static OutputForm oi = new OutputForm();
        public static int cc = 0;
        public static int cn = 3002;

        public InputForm(int myCC, int myCN)
        {
            cc = myCC;
            cn = myCN;
            InitializeComponent();
        }
        public InputForm()
        {
            InitializeComponent();
        }

        /*  
         *  AddToCheckButton_Click is the method that validates the user input and then store the input into three separate static strings.
         *  -First, the name text box is checked to determine whether or not anything was entered.
         *  -Second, the amount text box is checked to ensure a double was entered (or rather, a string that can be parsed into a double), then that amount string
         *    is ran through a check to determine if there is one (and only one) decimal point. If multiple decimal points are detected, an error message appears.
         *    If no decimals are detected, the string ".00" will be appended to the string then stored.
         *  -No validation is performed on the Memo input, since it is an optional field.
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
        } // end AddToCheckButton_Click()

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
            /*
             *  ***Can add clear check fields here if desired.***
             */
        }

        private void SubmitCheckButton_Click(object sender, EventArgs e)
        {
            /*
             *  ***Add input processor method calls here, pass handling to output interface?
             */
        }

        public string getName() {
            return cName;
        }

        public string getDollar()
        {
            return cAmount;
        }

        public string getMemo()
        {
            return cMemo;
        }

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
        }

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
            }
        }

        public bool validateMemoField()
        {
            bool isValid = true;
            if (MemoTextBox.Text.Length > 30)
            {
                MemoErrorLabel.Visible = true;
                return !isValid;
            }
            else
            {
                MemoErrorLabel.Visible = false;
                cMemo = MemoTextBox.Text;
                return isValid;
            }
        }
    }
}
