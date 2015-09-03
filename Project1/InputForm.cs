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
        static int deciNum { get; set; }
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
            deciNum = 0;

            if (NameTextBox.Text.Length == 0)
            {
                NameErrorLabel.Visible = true;
            }
            else
            {
                NameErrorLabel.Visible = false;
                cName = NameTextBox.Text;
            }

            double n;
            if (double.TryParse(AmountTextBox.Text, out n)) //If the amount string can be parsed as a double...
            {
                //Console.WriteLine("Double parsing successful!");
                AmountErrorLabel.Visible = false;
                //Console.WriteLine("n = " + n);
                cAmount = n.ToString();
                //Console.WriteLine("cAmount = " + cAmount);
                deciNum = AmountTextBox.Text.Split('.').Length - 1;  //Count the number of decimals in the Amount string
                //Console.WriteLine("DeciNum = " + deciNum);
                if (deciNum == 1 || deciNum == 0) //If the amount string has either one or zero decimals (the only acceptable amounts of decimals)...
                {
                    //Console.WriteLine("The number of decimals is either 1 or 0.");
                    cAmount = Math.Round(n, 2).ToString();
                    AmountErrorLabel.Visible = false;

                    //SUCCESS HERE, PASS TO FORM
                    cMemo = MemoTextBox.Text;

                    //causes error
                    //cDollarString = InputProcessor.parseInput(cDollarString);

                    this.Hide();
                    cc++; //increase the check count before starting the new form
                    cn++; //increase the check number before starting the new form
                    OutputForm oi = new OutputForm(cc, cn);
                    oi.ShowDialog();
                }
                else
                {
                    //Console.WriteLine("The number of decimals is something other than 1 or 0.");
                    AmountErrorLabel.Visible = true;
                }
            }
            else
            {
                //Console.WriteLine("Double parsing failed!");
                AmountErrorLabel.Visible = true;
            }


            Console.WriteLine("cName = " + cName + ", cAmount = " + cAmount + ", cMemo = " + cMemo);
           
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
    }
}
