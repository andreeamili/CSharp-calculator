using System;
using System.Collections.Generic;
using System.Linq;

namespace Calculator
{ 
    class PolishForm : Operation
    {
        private Stack<char> stackPolishForm = new Stack<char>();

        private Stack<decimal> stackCalculation = new Stack<decimal>();
          
        private decimal numberOne, numberTwo, numberForSingleOperation, result;   

        private string expresion, polishForm;  

        public PolishForm(string polo)
        {
            expresion = polo;
            numberOne  = 0m;
            numberTwo = 0m;
            numberForSingleOperation = 0;
            result = 0m;
            polishForm = "";
        }
        public override string PoloForm()
        {
            expresion = "(" + expresion + ")";
            int checkNegativeNumber = 0;
            for(int index=0;index<expresion.Length;index++)
            {
                if(checkNegativeNumber == 1 && expresion[index]=='-')
                {
                    stringOfNumbers.numbers = stringOfNumbers.numbers + expresion[index];
                }
                else
                {
                    checkNegativeNumber++;
                }
                if (expresion[index] >= '0' && expresion[index] <= '9' || expresion[index] == '.')
                {
                    stringOfNumbers.numbers = stringOfNumbers.numbers + expresion[index];
                    checkNegativeNumber++;
                }
                if(expresion[index]=='(')
                {
                    stackPolishForm.Push(expresion[index]);
                }
                if(expresion[index] ==')')
                {
                    AddRightBraecket(); 
                }
                if ((expresion[index] == '+' || expresion[index] == '-') && (checkNegativeNumber != 1))
                {
                    AddMinusOrPlus(index);
                }
                if (expresion[index] == '*' || expresion[index] == '/')
                {
                    AddMultiplayOrDivide(index); 
                }
                if (expresion[index] == '√')
                {
                    AddRadical(index);
                }
                if (expresion[index] == 's' || expresion[index] == 'c' || expresion[index] == 't')
                {
                    AddTrigronometricFunctions(index);
                }
            }
            return polishForm;
        }

        public override decimal CalculFinal(string poloFrom)
        {
            int checkNegativeNumber = 0;
            string temporaryNumber = ""; 
            decimal finalResult = 0m;   
            decimal number = 0m; 
            for (int index = 0; index < poloFrom.Length; index++)
            {
                if (checkNegativeNumber == 0 && poloFrom[index] == '-')
                {
                    temporaryNumber = temporaryNumber + poloFrom[index];
                }
                else 
                {
                    checkNegativeNumber++;
                }
                if (poloFrom[index] >= '0' && poloFrom[index] <= '9' || poloFrom[index] == '.')
                {
                    temporaryNumber = temporaryNumber + poloFrom[index];
                }
                if (poloFrom[index] == ' ' && poloFrom[index + 1] != ' ')
                {
                    number = decimal.Parse(temporaryNumber.Replace(".", ","));
                    temporaryNumber = "";
                    PushS(number);
                    number = 0m; 
                }
                if (poloFrom[index] == '+' || poloFrom[index] == '-' || poloFrom[index] == '*' || poloFrom[index] == '/')
                {
                    Calculate(poloFrom[index]);
                }
                if (poloFrom[index] == 's' || poloFrom[index] == 'c' || poloFrom[index] == 't' || poloFrom[index] == '√')
                {
                    CalculateTrigo(poloFrom[index]);
                }
            }
            if (stackCalculation.Count() != 0)
            {
                finalResult = Convert.ToDecimal(stackCalculation.Peek());
                return finalResult;
            }
            else
            {
                return 1;
            }
        }
         
        private void AddRightBraecket()
        {
            if (stringOfNumbers.numbers != "")
            {
                polishForm = polishForm + stringOfNumbers.numbers + " ";
            }
            stringOfNumbers.numbers = "";
        
            while (stackPolishForm.Peek() != '(')
            {
                polishForm += stackPolishForm.Peek();
                stackPolishForm.Pop();
            }
            stackPolishForm.Pop();
        } 

        private void AddMinusOrPlus(int index)
        {
            if (stringOfNumbers.numbers != "")
            {
                polishForm = polishForm + stringOfNumbers.numbers + " ";
            }
            stringOfNumbers.numbers = "";
            if ((stackPolishForm.Count() > 0 || stackPolishForm.Peek() == '(' || expresion[index - 1] == '(') && (stackPolishForm.Peek() != '-' && stackPolishForm.Peek() != '+'
                && stackPolishForm.Peek() != '*' && stackPolishForm.Peek() != '/' && stackPolishForm.Peek() != '√' && stackPolishForm.Peek() != 'c'
                && stackPolishForm.Peek() != 's' && stackPolishForm.Peek() != 't'))
            {
                stackPolishForm.Push(expresion[index]);
            }
            else
            {
                polishForm = polishForm + stackPolishForm.Peek();
                stackPolishForm.Pop();
                stackPolishForm.Push(expresion[index]);
            }
        }
        private void AddRadical(int index)
        {
            if (index != 1 && stringOfNumbers.numbers != "")
            {
                polishForm = polishForm + stringOfNumbers.numbers + " ";
                stringOfNumbers.numbers = "";
            }
            if ((stackPolishForm.Count() > 0 || stackPolishForm.Peek() == '(') && stackPolishForm.Peek() != 'r')
            {
                stackPolishForm.Push(expresion[index]);
            }
            else
            {
                polishForm = polishForm + stackPolishForm.Peek();
                stackPolishForm.Pop();
                stackPolishForm.Push(expresion[index]);
            }
        }

        private void AddMultiplayOrDivide(int index)
        {
            if (stringOfNumbers.numbers != "")
            {
                polishForm = polishForm + stringOfNumbers.numbers + " ";
            }
            stringOfNumbers.numbers = "";
            if ((stackPolishForm.Count() > 0 || stackPolishForm.Peek() == '(' || stackPolishForm.Peek() == '+' || stackPolishForm.Peek() == '-') &&
                (stackPolishForm.Peek() != '*' && stackPolishForm.Peek() != '/' && stackPolishForm.Peek() != '√'))
            {
                stackPolishForm.Push(expresion[index]);
            }
            else
            {
                polishForm = polishForm + stackPolishForm.Peek();
                stackPolishForm.Pop();
                stackPolishForm.Push(expresion[index]);
            }
        }
         
        private void AddTrigronometricFunctions(int index)
        {
            if (index != 1)
            {
                if (stringOfNumbers.numbers != "")
                    polishForm = polishForm + stringOfNumbers.numbers + " ";
                {
                    stringOfNumbers.numbers = "";
                }
            }
            if ((stackPolishForm.Count() > 0 || stackPolishForm.Peek() == '(' || stackPolishForm.Peek() == '+' ||
                stackPolishForm.Peek() == '-' || expresion[index] == '*' || expresion[index] == '/')
                && (stackPolishForm.Peek() != 't' && stackPolishForm.Peek() != 's' && stackPolishForm.Peek() != 'c'))
            {
                stackPolishForm.Push(expresion[index]);
            }
            else
            {
                polishForm += stackPolishForm.Peek();
                stackPolishForm.Pop();
            }
        }

        private void PushS(decimal nr)
        {
            stackCalculation.Push(nr);
        }
        private int GetTwo()
        {
            if (stackCalculation.Count() < 2)
            {
                return 0;
            }
            numberTwo = stackCalculation.Peek();
            stackCalculation.Pop();
            numberOne = stackCalculation.Peek();
            stackCalculation.Pop();
            return 1;
        }
        private int GetOne()
        {
            if (stackCalculation.Count() < 1)
            {
                return 0;
            }
            numberForSingleOperation = stackCalculation.Peek();
            stackCalculation.Pop();
            return 1;
        }
        private void Calculate(char operation)
        {
            if(GetTwo()!=0) 
            {
                switch(operation)
                {
                    case '+': result = numberOne + numberTwo; break;

                    case '-': result = numberOne - numberTwo; break;

                    case '*': result = numberOne *  numberTwo; break;

                    case '/': result = numberOne / numberTwo; break;

                }
                stackCalculation.Push(result);
            }
        }
        private void CalculateTrigo(char trigonometricOrSquare)
        {
            if (GetOne() != 0)
            {
                switch (trigonometricOrSquare)

                {
                    case 's': result = (decimal)Math.Sin((double)numberForSingleOperation * (Math.PI) / 180); break;

                    case 'c': result = (decimal)Math.Cos((double)numberForSingleOperation * (Math.PI) / 180); break;

                    case 't': result = (decimal)Math.Tan((double)numberForSingleOperation * (Math.PI) / 180); break;

                    case '√': result = (decimal)Math.Sqrt((double)numberForSingleOperation); break;

                }
            }
            stackCalculation.Push(result);
        }
    } 
}
