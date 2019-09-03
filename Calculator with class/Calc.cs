using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_with_class
{
    public class Calc
    {
        /// <summary>
        /// Declaring the properties for this clas
        /// </summary>
        public double Num1 { get; set; }
        public double Num2 { get; set; }
        //to show +, -, *, / symbols in you combubo box you need to declare another properties
        public string SelectedSymbol { get; set; }
        //Now its time to creat the methods

        /// <summary>
        /// To add two numbers
        /// </summary>
        public double Add(double one, double two)
        {
            return one + two;
        }
        /// <summary>
        /// To Multiply two numbers
        /// </summary>
        public double Multiply(double one, double two)
        {
            return one * two;
        }
        /// <summary>
        /// To Subtract two numbers
        /// </summary>
        public double Subtract(double one, double two)
        {
            return one - two;
        }
        /// <summary>
        /// To Divided two numbers
        /// </summary>
        public double Divide(double one, double two)
        {
            return one / two;
        }
        /// <summary>
        /// Method to load symbols to the combobox
        /// </summary>
        /// <returns></returns>
        public string [] LoadSymbols()
        {
            string[] ComboBoxItems = new[] { "Select operation", "+", "-", "*", "/" };
            return ComboBoxItems;
        }
        public double SelectOperation()
        {
            double Answer = 0;
            switch(SelectedSymbol)
            {
                case "+":
                    Answer = Add(Num1, Num2);
                    break;
                case "-":
                    Answer = Subtract(Num1, Num2);
                    break;
                case "*":
                    Answer = Multiply(Num1, Num2);
                    break;
                case "/":
                    Answer = Divide(Num1, Num2);
                    break;
            }
            return Answer;
        }
    }
}
