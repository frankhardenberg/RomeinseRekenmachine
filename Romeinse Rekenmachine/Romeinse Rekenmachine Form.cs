using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Romeinse_Rekenmachine
{
    public partial class Romeinse_Rekenmachine : Form
    {
        public Romeinse_Rekenmachine()
        {
            InitializeComponent();
        }

        char[] Operators = { '-', '+', '/', '*' };
        string Operation;
        int Result = 0;
        int First;
        int Second;
        bool EqualsClicked;
        int OperatorCount2;
        string InputString;
        string FirstString;
        string SecondString;
        string Res;
        string ClearClickText;
        string RomanTwoAndThree;

        private string NaarRomGet(int getal)
        {
            if (getal < 1) return string.Empty;
            if (getal >= 1000) return "M" + NaarRomGet(getal - 1000);
            if (getal >= 900) return "CM" + NaarRomGet(getal - 900);
            if (getal >= 500) return "D" + NaarRomGet(getal - 500);
            if (getal >= 400) return "CD" + NaarRomGet(getal - 400);
            if (getal >= 100) return "C" + NaarRomGet(getal - 100);
            if (getal >= 90) return "XC" + NaarRomGet(getal - 90);
            if (getal >= 50) return "L" + NaarRomGet(getal - 50);
            if (getal >= 40) return "XL" + NaarRomGet(getal - 40);
            if (getal >= 10) return "X" + NaarRomGet(getal - 10);
            if (getal >= 9) return "IX" + NaarRomGet(getal - 9);
            if (getal >= 5) return "V" + NaarRomGet(getal - 5);
            if (getal >= 4) return "IV" + NaarRomGet(getal - 4);
            if (getal >= 1) return "I" + NaarRomGet(getal - 1);

            return String.Empty;
        }

        private int NaarIntGet(string RomGet)
        {
            if (RomGet == null) return 0;

            RomGet = RomGet.ToUpper();
            if (RomGet.Length == 0) return 0;
            if (RomGet.Length >= 2)
            {
                if (RomGet.Substring(0, 2) == "CM") return 900 + NaarIntGet(RomGet.Substring(2));
                if (RomGet.Substring(0, 2) == "CD") return 400 + NaarIntGet(RomGet.Substring(2));
                if (RomGet.Substring(0, 2) == "XC") return 90 + NaarIntGet(RomGet.Substring(2));
                if (RomGet.Substring(0, 2) == "XL") return 40 + NaarIntGet(RomGet.Substring(2));
                if (RomGet.Substring(0, 2) == "IX") return 9 + NaarIntGet(RomGet.Substring(2));
                if (RomGet.Substring(0, 2) == "IV") return 4 + NaarIntGet(RomGet.Substring(2));
            }

            if (RomGet.Substring(0, 1) == "M") return 1000 + NaarIntGet(RomGet.Substring(1));
            if (RomGet.Substring(0, 1) == "D") return 500 + NaarIntGet(RomGet.Substring(1));
            if (RomGet.Substring(0, 1) == "C") return 100 + NaarIntGet(RomGet.Substring(1));
            if (RomGet.Substring(0, 1) == "L") return 50 + NaarIntGet(RomGet.Substring(1));
            if (RomGet.Substring(0, 1) == "X") return 10 + NaarIntGet(RomGet.Substring(1));
            if (RomGet.Substring(0, 1) == "V") return 5 + NaarIntGet(RomGet.Substring(1));
            if (RomGet.Substring(0, 1) == "I") return 1 + NaarIntGet(RomGet.Substring(1));

            return 0;
        }

        private void Input_TextChanged(object sender, EventArgs e)
        {

        }

        private void Output_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void Numbers_Click(object sender, EventArgs e)
        {
            Button senderButton = (Button)sender;
            if (senderButton != null)
            {
                Input.Text += (senderButton.Text);
            }

            if (EqualsClicked == true)
            {
            }

            else
            {
                First = NaarIntGet(Input.Text);
            }
        }

        public void StringSplitter()
        {
            InputString = Input.Text;
            string[] inputArray = InputString.Split(' ');
            List<string> numbers = new List<string>();
            List<string> operators = new List<string>();
            
            foreach (var part in inputArray)
            {
                if (part == "+" || part == "-" || part == "*" || part == "/")
                {
                    operators.Add(part);
                }

                else
                {
                    numbers.Add(part);
                }
            }

            int j = 0;

            foreach (var op in operators)
            {
                OperatorCount2++;

                if (OperatorCount2 == 1 && OperatorCount2 != 0)
                {
                    FirstString = numbers[j];
                    First = NaarIntGet(FirstString);
                    SecondString = numbers[j + 1];
                    Second = NaarIntGet(SecondString);
                    Result = Calculate(First, op, Second);
                }

                else
                {
                    j++;
                    First = Result;
                    SecondString = numbers[j + 1];
                    Second = NaarIntGet(SecondString);
                    Result = Calculate(First, op, Second);
                }
            }
        }

        private int Calculate(int First, string op, int Second)
        {
            if (op == "+")
            {
                return First + Second;
            }

            else if (op == "-")
            {
                return First - Second;
            }

            else if (op == "*")
            {
                return First * Second;
            }

            else if (op == "/")
            {
                return First / Second;
            }

            return 0;
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            Button senderButton = (Button)sender;
            Operation = senderButton.Text;
            Input.Text += " " + Operation + " ";
        }

        private void Equals_Click(object sender, EventArgs e)
        {
            EqualsClicked = true;

            if (First > 3000 || Second > 3000)
            {
                Input.Text = "Inputs cannot be above 3000.";
            }

            StringSplitter();

            if (Result > 3000)
            {
                Output.Text = "Result cannot be above 3000.";               
            }            

            if (Result <= 3000)
            {
                Operation = String.Empty;
                Output.Text = NaarRomGet(Result);
                OperatorCount2 = 0;
            }
        }

        public string RemoveWhitespace(string InputString)
        {
            InputString = Input.Text;
            Res = String.Empty;

            foreach (var character in InputString)
            {
                if (character != ' ')
                {
                    Res += character;
                }
            }

            return Res;
        }

        public string AddWhitespace(string Res)
        {
            InputString = Res;
            ClearClickText = String.Empty;

            foreach (var character in InputString)
            {
                if (InputString.Contains("II") || InputString.Contains("III"))
                {
                    RomanTwoAndThree += character.ToString();
                    RemoveWhitespace(RomanTwoAndThree);
                }

                else
                {
                    ClearClickText += character.ToString() + (' ');
                    InputString = ClearClickText;
                }
            }

            return InputString;           
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Input.Text = "";
            Output.Text = "";
            EqualsClicked = false;
            OperatorCount2 = 0;
            Result = 0;
        }

        private void Clear_Entry_Click(object sender, EventArgs e)
        {
            if (Input.Text.Length == 0 || InputString.Length == 0)
            {
                Input.Text = String.Empty;
            }

            if (Input.Text.Length >= 1)
            {
                RemoveWhitespace(Input.Text);
                Res = Res.Substring(0, Res.Length - 1);
                AddWhitespace(Res);
                Input.Text = InputString.Substring(0, InputString.Length - 1);                                             
            }            

            if (Output.Text.Length >= 1)
            {
                Output.Text = Output.Text.Substring(0, Output.Text.Length - 1);
            }            
        }
    }
}


       

            