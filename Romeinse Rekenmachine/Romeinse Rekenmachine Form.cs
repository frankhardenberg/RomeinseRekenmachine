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
            Input.Text = "-";
            Output.Text = "-";
        }
                
        public int First;
        public int  Second;
        public int Result = 0;
        
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
            First = NaarIntGet(Input.Text);
            First = Second;
            Second = NaarIntGet(Input.Text);
            First = NaarIntGet(Input.Text);
        }

        private void Output_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Numbers_Click(object sender, EventArgs e)
        {
            Button senderButton = (Button)sender;
            if (senderButton != null)
            {
                Input.Text = (senderButton.Text);
            }
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            string Operation = "";
            Button senderButton = (Button)sender;
            Operation = senderButton.Text;

            Input.Text = First.ToString();
            First = Second;
            Input.Text = First.ToString();            

            switch (Operation)
            {
                case "+":
                    Result = First + Second;
                    break;
                case "-":
                    Result = First - Second;
                    break;
                case "/":
                    Result = First / Second;
                    break;
                case "*":
                    Result = First * Second;
                    break;
                default:
                    break;
            }
        }

        private void Equals_Click(object sender, EventArgs e)
        {

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Input.Text = "";
            Input.Text = "-";
            Output.Text = "";
            Output.Text = "-"; 
        }

        private void Clear_Entry_Click(object sender, EventArgs e)
        {
            //Later nog invoer aan geven. Nu nog niet nodig.
        }

        private void UpdateView()
        {
            Output.Text = NaarRomGet(Result);
        }
    }
}
