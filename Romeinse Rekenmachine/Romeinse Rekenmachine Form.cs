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
            Input.Text = "";
            Output.Text = "";
        }

        char[] Operators = {'-', '+', '/', '*'};
        string Operation;
        string Input2;
        string SplitString;
        int Result = 0;
        int First;
        int Second;
        bool EqualsClicked;
        int StringSplitCounter = 0;
        int Count = 0;
        int OperatorCount = 0;
        int InputCount = 0;

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

            return ("");
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
            int i;
            foreach (char Operator in Operators)
            {
                InputCount++;
                Count++;
            }            

            if (Input.Text.Contains('-'))
            {
                SplitString = Input.Text.Substring(StringSplitCounter);
                First = NaarIntGet(SplitString);
                StringSplitCounter += 4;
                SplitString = Input.Text.Substring(StringSplitCounter);
                Second = NaarIntGet(SplitString);
                StringSplitCounter += 4;
                Result = First - Second;

                if (InputCount > 0)
                {
                    for (i = 0; i < InputCount - 1; i++)
                    {
                        First = Result;
                        SplitString = Input.Text.Substring(StringSplitCounter);
                        Second = NaarIntGet(SplitString);
                        StringSplitCounter += 4;
                        Result = First - Second;
                    }
                }
            }

            if (Input.Text.Contains('+'))
            {
                SplitString = Input.Text.Substring(StringSplitCounter);
                First = NaarIntGet(SplitString);
                StringSplitCounter += 4;
                SplitString = Input.Text.Substring(StringSplitCounter);
                Second = NaarIntGet(SplitString);
                StringSplitCounter += 4;
                Result = First + Second;

                if (InputCount > 0)
                {
                    for (i = 0; i < InputCount - 1; i++)
                    {
                        First = Result;
                        SplitString = Input.Text.Substring(StringSplitCounter);
                        Second = NaarIntGet(SplitString);
                        StringSplitCounter += 4;
                        Result = First + Second;
                    }
                }
            }

            if (Input.Text.Contains('*'))
            {
                SplitString = Input.Text.Substring(StringSplitCounter);
                First = NaarIntGet(SplitString);
                StringSplitCounter += 4;
                SplitString = Input.Text.Substring(StringSplitCounter);
                Second = NaarIntGet(SplitString);
                StringSplitCounter += 4;
                Result = First * Second;

                if (InputCount > 0)
                {
                    for (i = 0; i < InputCount - 1; i++)
                    {
                        First = Result;
                        SplitString = Input.Text.Substring(StringSplitCounter);
                        Second = NaarIntGet(SplitString);
                        StringSplitCounter += 4;
                        Result = First * Second;
                    }                                   
                }
            }

            if (Input.Text.Contains('/'))
            {
                SplitString = Input.Text.Substring(StringSplitCounter);
                First = NaarIntGet(SplitString);
                StringSplitCounter += 4;
                SplitString = Input.Text.Substring(StringSplitCounter);
                Second = NaarIntGet(SplitString);
                StringSplitCounter += 4;
                Result = First / Second;

                if (InputCount > 0)
                {
                    for (i = 0; i < InputCount - 1; i++)
                    {
                        First = Result;
                        SplitString = Input.Text.Substring(StringSplitCounter);
                        Second = NaarIntGet(SplitString);
                        StringSplitCounter += 4;
                        Result = First / Second;
                    }
                }
            }            
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            OperatorCount++;

            Button senderButton = (Button)sender;
            Operation = senderButton.Text;
            Input.Text += " " + Operation + " ";

            if (Operation != "")
            {
                Second = NaarIntGet(Input.Text);
            }            
        }

        private void Equals_Click(object sender, EventArgs e)
        {
            EqualsClicked = true;

            if (First > 3001 || Second > 3001)
            {
                Input.Text = "Index out of range.";
                MessageBox.Show("Index out of range.");
            }
            
            StringSplitter();
            Recalculate();            

            if (Result > 3001)
            {
                Output.Text = "Index out of range.";
                MessageBox.Show("Index out of range.");
            }

            Operation = "";
            Output.Text = NaarRomGet(Result);
        }

        public void Recalculate()
        {
            switch (Operation)
            {
                case "+":
                    Result = First + Second;
                    if (Second == 0)
                    {
                        MessageBox.Show("Add zero exception.");
                    }
                    break;
                case "-":
                    Result = First - Second;
                    if (Second == 0)
                    {
                        MessageBox.Show("Minus zero exception.");
                    }
                    break;
                case "/":
                    Result = First / Second;
                    if (First == 0 || Second == 0)
                    {
                        MessageBox.Show("Divide by zero exception.");
                    }
                    break;
                case "*":
                    Result = First * Second;
                    if (First == 0 || Second == 0)
                    {
                        MessageBox.Show("Multiply by zero exception.");
                    }
                    break;
                default:
                    break;
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Input.Text = "";
            Output.Text = "";
            EqualsClicked = false;
        }

        private void Clear_Entry_Click(object sender, EventArgs e)
        {
            if (Input.Text.Length >= 1)
            {
                Input.Text = Input.Text.Substring(0, Input.Text.Length - 1);
            }

            if (Output.Text.Length >= 1)
            {
                Output.Text = Output.Text.Substring(0, Output.Text.Length - 1);
            }

            if (Output.Text.Length == 0)
            {
                EqualsClicked = false;
            }            
        }
    }
}
