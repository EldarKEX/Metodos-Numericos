using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecuations
{
    public class Tokens
    {

        const int LEFT_ASOCIATIVE = 0;
        const int RIGHT_ASOCIATIVE = 1;

        public Dictionary<string, Operator> dic = new Dictionary<string, Operator>();

        public Tokens()
        {
            dic.Add("+", new Operator { operatorCode = "+", asociativity = LEFT_ASOCIATIVE, precedence = 0 });
            dic.Add("-", new Operator { operatorCode = "-", asociativity = LEFT_ASOCIATIVE, precedence = 0 });
            dic.Add("*", new Operator { operatorCode = "*", asociativity = LEFT_ASOCIATIVE, precedence = 1 });
            dic.Add("/", new Operator { operatorCode = "/", asociativity = LEFT_ASOCIATIVE, precedence = 1 });
            dic.Add("^", new Operator { operatorCode = "^", asociativity = RIGHT_ASOCIATIVE, precedence = 2 });
            dic.Add("√", new Operator { operatorCode = "√", asociativity = RIGHT_ASOCIATIVE, precedence = 2 });

        }

        public List<string> CorrectList(Queue<string> queue)
        {
            List<string> answer = new List<string>();
            string before = "";
            string actual = "";
            while(queue.Count > 0)
            {
                actual = queue.Dequeue();

                if(actual == "-" && answer.Count == 0 && queue.Peek() != "(")
                {
                    actual += queue.Dequeue();
                    answer.Add(actual);
                    before = actual;
                    continue;
                }

                if(before == "(" && actual == "-")
                {
                    actual += queue.Dequeue();
                    answer.Add(actual);
                    before = actual;
                    continue;
                }

                if(actual == " ")
                {
                    continue;
                }

                if ((actual == "-" && before == "*") || (actual == "-" && before == "/") || (actual == "-" && before == "^"))
                {
                    actual += queue.Dequeue();
                    answer.Add(actual);
                    before = actual;
                    continue;
                }

                answer.Add(actual);
                before = actual;
            }

            return answer;
        }

        public List<string> Convert(string ecuation)
        {
            Queue<string> result = new Queue<string>();


            ecuation = ecuation.Replace("+", "~+~").Replace("*", "~*~").Replace("-", "~-~").Replace("/", "~/~").Replace("^", "~^~").Replace("(", "~(~").Replace(")", "~)~").Replace("√", "~√~");

            

            foreach (string token in ecuation.Split('~'))
            {
                if(token == "")
                {
                    continue;
                }
                result.Enqueue(token);
            }

            return CorrectList(result);
        }

        public bool IsOperator(string token)
        {
            if (dic.ContainsKey(token))
            {
                return true;
            }

            return false;
        }


        public string ParseVariable(string variable, string value, string operation)
        {
            return operation.Replace(variable,"*" + value);
        }
    }

    
}
