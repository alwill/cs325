using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Project1
{
    public class Tally : OutputForm
    {
       
        //instance variables
        private static int i;
        private static double rt;
        //OutputForm output  = new OutputForm();
      //  InputForm input = new InputForm();
        //ctor
    
        //toString
        public string toString()
        {
            return "Tally: " + i + "Running Total: " + rt;
        }

        //getters and setters
        public int I
        {
            get { return i; }
            set { i = value; }
        }
        public double RT
        {
            get { return rt; }
            set { rt = value; }
        }

        //methods
        public void resetTallyAndRunningTotal()
        {
            i = 0;
            rt = 0;
        }

        public static void addCheck(double amount)
        {
            i++;
            rt += amount;
            //output.((int)i);
            //output.SetSumLabels((double)rt);
        }

        public static string checkSum(string amount)
        {
            double newAmount = double.Parse(amount);
            rt += newAmount;
            return "$" + rt.ToString("F");
        } 
        public static int checkCount()
        {
            i++;
            return i;
        }
    }
}