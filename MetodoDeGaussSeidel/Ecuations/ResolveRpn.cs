using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ecuations
{
    public class ResolveRpn
    {
        public string Convert(Queue<string> rpn)
        {
            string answer = "";
            Stack<string> numberStack = new Stack<string>();

            double op1 = 0;
            double op2 = 0;

            InfixToRpn inFunc = new InfixToRpn();



            while(rpn.Count != 0)
            {
                string token = rpn.Dequeue();
                switch (token)
                {
                    case "+":
                        op1 = double.Parse(numberStack.Pop());
                        op2 = double.Parse(numberStack.Pop());

                        numberStack.Push((op2 + op1).ToString());
                        break;
                    case "-":

                        op1 = double.Parse(numberStack.Pop());

                        if (numberStack.Count == 0)
                        {
                            op2 = 0;
                        }
                        else
                        {
                            op2 = double.Parse(numberStack.Pop());
                        }
                            
                        numberStack.Push((op2 - op1).ToString());
                        break;
                    case "*":

                        op1 = double.Parse(numberStack.Pop());
                        op2 = double.Parse(numberStack.Pop());

                        numberStack.Push((op2 * op1).ToString());
                        break;
                    case "/":
                        op1 = double.Parse(numberStack.Pop());
                        op2 = double.Parse(numberStack.Pop());

                        numberStack.Push((op2 / op1).ToString());
                        break;
                    case "^":
                        op1 = double.Parse(numberStack.Pop());
                        op2 = double.Parse(numberStack.Pop());

                        numberStack.Push((Math.Pow(op2,op1).ToString()));
                        break;
                    case "√":                  

                        op1 = double.Parse(numberStack.Pop());

                        if(op1 < 0)
                        {
                            return "Error";
                        }

                        numberStack.Push((Math.Sqrt(op1)).ToString());
                        break;
                    default:
                        numberStack.Push(token);
                        break;
                }

            }

            return numberStack.Pop();
        }
    }
}
