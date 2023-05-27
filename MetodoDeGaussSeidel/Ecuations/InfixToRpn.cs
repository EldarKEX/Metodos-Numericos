using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecuations
{
    public class InfixToRpn
    {
        const int LEFT_ASOCIATIVE = 0;
        const int RIGHT_ASOCIATIVE = 1;

        public Dictionary<string, Operator> dic = new Dictionary<string, Operator>();

        private Queue<string> output;
        private Stack<string> stackOperator;

        

        public InfixToRpn()
        {
            dic.Add("+", new Operator { operatorCode = "+", asociativity = LEFT_ASOCIATIVE, precedence = 0 });
            dic.Add("-", new Operator { operatorCode = "-", asociativity = LEFT_ASOCIATIVE, precedence = 0 });
            dic.Add("*", new Operator { operatorCode = "*", asociativity = LEFT_ASOCIATIVE, precedence = 1 });
            dic.Add("/", new Operator { operatorCode = "/", asociativity = LEFT_ASOCIATIVE, precedence = 1 });
            dic.Add("^", new Operator { operatorCode = "^", asociativity = RIGHT_ASOCIATIVE, precedence = 2 });
            dic.Add("√", new Operator { operatorCode = "√", asociativity = RIGHT_ASOCIATIVE, precedence = 2 });
        }

        public Queue<string> Convert(List<string> tokens)
        {

            output = new Queue<string>();
            stackOperator = new Stack<string>();

            foreach (string token in tokens)
            {
                if(token == " ")
                {
                    continue;
                }


                if (token == "(")
                {
                    stackOperator.Push("(");
                    continue;
                }

                if (token == ")")
                {
                    while (stackOperator.Peek() != "(")
                    {
                        if (stackOperator.Count == 0)
                        {
                            return output;
                        }

                        output.Enqueue(stackOperator.Pop());
                    }

                    stackOperator.Pop();
                    continue;
                }


                if (new Tokens().IsOperator(token))
                {


                    while (stackOperator.Count > 0 && new Tokens().IsOperator(stackOperator.Peek()))       
                    {
                        if (
                            (
                                dic[token].asociativity == LEFT_ASOCIATIVE && dic[token].precedence <= dic[stackOperator.Peek()].precedence
                            )
                            ||
                            (
                                 dic[token].asociativity == RIGHT_ASOCIATIVE && dic[token].precedence < dic[stackOperator.Peek()].precedence
                            )
                        ) 
                        {

                            output.Enqueue(stackOperator.Pop());
                            continue;
                        }

                        break;
                            
                    }

                    stackOperator.Push(token);
                    continue;
                
                }

                               
                output.Enqueue(token);
                              

            }  
            
            while(stackOperator.Count != 0)
            {
                output.Enqueue(stackOperator.Pop());
            }


            return output;
        }
    }
}
