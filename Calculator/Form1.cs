using System;
using System.Windows.Forms;
using System.IO;
using System.Linq;

namespace Calculator
{
    public partial class Calculator_Form : Form
    {
        private string initialPolishForm="";   

        private string historyOutput = ""; 

        private string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop),"Out.txt");

        private Operation polishForm; 

        public Calculator_Form()
        {
            InitializeComponent();
        } 

        private void btnDelete_Click(object sender, EventArgs e)
        {
            output.Text = "0";
            btnScreen.Text = "\n";
            initialPolishForm = "";
        }
        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (initialPolishForm.Count() > 1)
            {
                polishForm = new PolishForm(initialPolishForm);
                try
                {
                    decimal rez = polishForm.CalculFinal(polishForm.PoloForm());
                    output.Text = Convert.ToString(rez);
                    historyOutput = btnScreen.Text;
                    btnScreen.Text = btnScreen.Text + "=";
                    using (StreamWriter writer = File.AppendText("Out.txt"))
                    {
                        writer.WriteLine(historyOutput);
                        writer.WriteLine("=" + rez);
                    }
                }
                catch (ArithmeticException)
                {
                    output.Text = "Error";
                }
            }
            else output.Text = initialPolishForm;


        }
        private void btnShowHistory_Click(object sender, EventArgs e)
        {
            listHistory.Items.Clear();
            string line;
            StreamReader file = new StreamReader("Out.txt");
            while ((line = file.ReadLine()) != null)
            {
                listHistory.Items.Add(line);
            }
            file.Close();
        }

        private void btnSqrt_Click(object sender, EventArgs e) 
        {
            AddOperatorTrigo("√", "√");
        }

        private void btnSeven_Click_1(object sender, EventArgs e)
        {
            AddChar("7");
        }

        private void btnEight_Click_1(object sender, EventArgs e)
        {
            AddChar("8");
        }

        private void btnNine_Click_1(object sender, EventArgs e)
        {
            AddChar("9");
        }
         
        private void btnFour_Click_1(object sender, EventArgs e)
        {
            AddChar("4");
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            AddChar("5");
        }

        private void btnSix_Click_1(object sender, EventArgs e)
        {
            AddChar("6");
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            AddChar("1");
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            AddChar("2");
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            AddChar("3");
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            AddChar("0");
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {   if (initialPolishForm.Count() > 0 && btnScreen.Text != "")
            {
                AddOperator(".");
            }
        }

        private void btnDivide_Click_1(object sender, EventArgs e)
        {
            if (initialPolishForm.Count() > 0 && btnScreen.Text != "")
            {
                AddOperator("/");
            }
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {   if (initialPolishForm.Count() > 0 && btnScreen.Text != "")
            {
                AddOperator("*");
            }
        }

        private void btnSubstraction_Click(object sender, EventArgs e)
        {
            AddOperator("-");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (initialPolishForm.Count() > 0 && btnScreen.Text != "")
            {
                AddOperator("+");
            }
        }
        
        private void btnSin_Click(object sender, EventArgs e)
        {
            AddOperatorTrigo("s", "sin");
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            AddOperatorTrigo("c", "cos");
        }

        private void btnTag_Click(object sender, EventArgs e)
        {
            AddOperatorTrigo("t", "tag");
        }

        private void btnHistoryOut_Click(object sender, EventArgs e)
        {
            listHistory.Items.Clear();
            File.WriteAllText("Out.txt", String.Empty);
        }

        private void btnBracketL_Click(object sender, EventArgs e)
        {
            AddBracket(ConditionLeft(), "(");
        }

        private void btnBracketR_Click(object sender, EventArgs e)
        {
            AddBracket(ConditionRight(), ")");
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btnScreen.Text+=listHistory.SelectedItem.ToString();
            initialPolishForm = btnScreen.Text;
        }
        private void AddChar(string number)
        {
            if (output.Text == "0" && output.Text != null && !initialPolishForm.EndsWith(")"))
            {
                initialPolishForm += number;
                output.Text = number;
            }
            else
            {
                if (!initialPolishForm.EndsWith(")"))
                {
                    initialPolishForm += number;
                    output.Text = output.Text + number;
                }
            }
            btnScreen.Text = initialPolishForm;
        }

        private void AddBracket(bool condition, string op)
        {
            if (condition)
            {
                if (output.Text == "0" && output.Text != null)
                {
                    initialPolishForm += op;
                    output.Text = op;
                }
                else
                {
                    initialPolishForm += op;
                    output.Text = output.Text + op;
                }
            }
            btnScreen.Text = initialPolishForm;
        }
        private void AddOperator(string op)
        {
            if (!initialPolishForm.EndsWith("/") && !initialPolishForm.EndsWith("*") && !initialPolishForm.EndsWith("(") &&
                !initialPolishForm.EndsWith(".") && !initialPolishForm.EndsWith("s") && !initialPolishForm.EndsWith("c") &&
                !initialPolishForm.EndsWith("t") && !initialPolishForm.EndsWith("√") && !initialPolishForm.EndsWith("-") &&
                !initialPolishForm.EndsWith("+") )
            {
                initialPolishForm += op;
                output.Text = "0";
                btnScreen.Text = btnScreen.Text + op;
            }
        }
        private void AddOperatorTrigo(string op, string opOut)
        {
            if (!initialPolishForm.EndsWith("t") && !initialPolishForm.EndsWith(".") && !initialPolishForm.EndsWith("c") &&
                !initialPolishForm.EndsWith("s") && !initialPolishForm.EndsWith("√") && (initialPolishForm.EndsWith("-") ||
                initialPolishForm.EndsWith("+") || initialPolishForm.EndsWith("/") || initialPolishForm.EndsWith("*") ||
                initialPolishForm.Count() == 0))
            {
                initialPolishForm += op;
                output.Text = "0";
                btnScreen.Text = btnScreen.Text + opOut;
            }
        }
        private bool ConditionRight()
        {
            if (!initialPolishForm.EndsWith(".") && !initialPolishForm.EndsWith("(") && !initialPolishForm.EndsWith("-") &&
                !initialPolishForm.EndsWith("+") && !initialPolishForm.EndsWith("*") && !initialPolishForm.EndsWith("+")
                && !initialPolishForm.EndsWith("/") && !initialPolishForm.EndsWith("c") && !initialPolishForm.EndsWith("s")
                && !initialPolishForm.EndsWith("t") && !initialPolishForm.EndsWith("√") && initialPolishForm.Count() > 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool ConditionLeft()
        {
            if (!initialPolishForm.EndsWith(".") &&
                !initialPolishForm.EndsWith(")") && (initialPolishForm.EndsWith("-") || initialPolishForm.EndsWith("+") ||
                initialPolishForm.EndsWith("*") || initialPolishForm.EndsWith("/") || initialPolishForm.Count() == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
