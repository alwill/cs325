using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project1;


namespace Project1
{
    public partial class OutputForm : Form
    {
        //PASSING CHECK NUMBERS BACK AND FORTH IS NOT WORKING
        static public int checkCount = 1;
        static private int checkNumber = 3002;
        InputForm ip = new InputForm();
        public OutputForm()
        {
        
            InitializeComponent();
            // Get the current date.
            DateTime thisDay = DateTime.Today;
            // Display the date in the default (general) format.
            DateInputLabel.Text = "_____" + thisDay.ToString("d") + "_____";
            TopRightCheckNumLabel.Text = checkNumber.ToString();
           // NumberOfChecks.Text = checkCount.ToString();
            InputNameLabel.Text = ip.getName();
            InputAmountLabel.Text = ip.getDollar();
            InputMemoLabel.Text = ip.getMemo();
            CheckNumbBottomLabel.Text = checkNumber.ToString();
            AmountStringLabel.Text = InputProcessor.parseInput(ip.getDollar()) ;

            NumbOfChecksLabel.Text = Tally.checkCount().ToString();
            SumLabel.Text = Tally.checkSum(ip.getDollar());


        }

        //THIS BUTTON SUBMITS INFO IN TEXT BOX TO POPULATE CHECK
        private void button1_Click(object sender, EventArgs e)
        {
            //ALL OF THESE NOW MUST BE POPULATED IN CONSTRUCTOR
            //FROM GEOFF'S FIELDS OR GETTERS
            //InputNameLabel.Text = NameTextBox.Text;
            //InputAmountLabel.Text = DollarTextBox.Text;
            //InputMemoLabel.Text = MemoTextBox.Text;
           // AmountStringLabel.Text = InputProcessor.parseInput(InputAmountLabel.Text);
        }

        //THIS BUTTON CREATES A NEW CHECK BY INCREMENTING CHECK # AND CLEARING CHECK
        private void NewCheckButton_Click(object sender, EventArgs e)
        {
            //HANDLE CHECK NUMBER INCREMENTS
            //get current amount of checks written, parse to int, and increment
            //int newCheck = int.Parse(NumbOfChecksLabel.Text);
            NumbOfChecksLabel.Text = checkCount.ToString();
            //get current check number, parse to int, and increment
            //newCheck = int.Parse(TopRightCheckNumLabel.Text);
            TopRightCheckNumLabel.Text = checkNumber.ToString();
            CheckNumbBottomLabel.Text = checkNumber.ToString();
            checkCount++;
            checkNumber++;

            //CLEAR CURRENT CHECK FIELDS TO BLANK
            InputNameLabel.Text = "";
            InputAmountLabel.Text = "";
            InputMemoLabel.Text = "";

            this.Hide();
            //Project1 ii = new Project1();
            ip.ShowDialog();
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            //INPUT CLASS WILL HANDLE NAME LENGTH CONSTRAINTS WHEN "SUBMIT" BUTTON PUSHED
        }

        private void DollarTextBox_TextChanged(object sender, EventArgs e)
        {



            //INPUT CLASS WILL HANDLE DOLLAR CONSTRAINTS WHEN "SUBMIT" PUSHED
        }

        private void MemoTextBox_TextChanged(object sender, EventArgs e)
        {
            //INPUT CLASS WILL HANDLE MEMO LENGTH CONSTRAINTS 
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
