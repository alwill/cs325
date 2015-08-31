using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckInterface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Get the current date.
            DateTime thisDay = DateTime.Today;
            // Display the date in the default (general) format.
            DateInputLabel.Text = "_____" + thisDay.ToString("d") + "_____";
        }

        //THIS BUTTON SUBMITS INFO IN TEXT BOX TO POPULATE CHECK
        private void button1_Click(object sender, EventArgs e)
        {
            InputNameLabel.Text = NameTextBox.Text;
            InputAmountLabel.Text = DollarTextBox.Text;
            InputMemoLabel.Text = MemoTextBox.Text;
        }

        //THIS BUTTON CREATES A NEW CHECK BY INCREMENTING CHECK # AND CLEARING CHECK
        private void NewCheckButton_Click(object sender, EventArgs e)
        {
            //HANDLE CHECK NUMBER INCREMENTS
            //get current amount of checks written, parse to int, and increment
            int newCheck = int.Parse(NumbOfChecksLabel.Text);
            NumbOfChecksLabel.Text = (newCheck + 1).ToString();
            //get current check number, parse to int, and increment
            newCheck = int.Parse(TopRightCheckNumLabel.Text);
            TopRightCheckNumLabel.Text = (newCheck + 1).ToString();
            CheckNumbBottomLabel.Text = (newCheck + 1).ToString();

            //CLEAR CURRENT CHECK FIELDS TO BLANK
            InputNameLabel.Text = "";
            InputAmountLabel.Text = "";
            InputMemoLabel.Text = "";
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
    }
}
