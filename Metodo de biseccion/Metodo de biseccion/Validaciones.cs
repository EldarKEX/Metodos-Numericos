using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodo_de_biseccion
{
    public class OperacionesMatematicas
    {
        public bool ValidarParentesis(string operacion)
        {
            int countParentesis = 0;

            foreach(char digit in operacion)
            {
                if(digit == '(')
                {
                    countParentesis++;
                }
                if(digit == ')')
                {
                    countParentesis--;
                }
                if(countParentesis < 0)
                {
                    return false;
                }
            }
            return true;
        }

        public (int,int) SubstringParentesis(string operacion)
        {
            int posParentesisLeft = 0;
            int posParentesisRight = 0;

            int count = 0;
            foreach(char digit in operacion)
            {
                if(digit == '(')
                {
                    posParentesisLeft = count;
                }
                if(digit == ')')
                {
                    posParentesisRight = count;
                }
                count++;
            }
            return (posParentesisLeft, posParentesisRight);
        }

        public string SepararOperacion(string operacion, (int,int) posOperacion)
        {
            string nuevaOperacion = "";

            if(operacion[0] == '(')
            {
                posOperacion.Item1++;
                posOperacion.Item2--;
            }

            int diffPos = posOperacion.Item2 - posOperacion.Item1;
            string minOperacion = operacion.Substring(posOperacion.Item1, diffPos);


            string firstNumber = "";
            string secondNumber = "";

            nuevaOperacion = RealizarOperacion(minOperacion);

            return nuevaOperacion;
        }

        string RealizarOperacion(string subOperacion)
        {
            int pos = 0;
            string anotherSubOne = "";
            int posTwo = -1;
            string anotherSubTwo = "";
            int posLast = 0;
            foreach (char digit in subOperacion)
            {
                if (digit == '+' || digit == '-' || digit == '/' || digit == '*' || digit == '^')
                {
                    if(anotherSubOne == "")
                    {
                        anotherSubOne = subOperacion.Substring(0, pos - 1);
                        posTwo = pos + 1;
                    }
                    else
                    {
                        anotherSubTwo = subOperacion.Substring(posTwo, pos - posTwo);
                        posLast = pos;
                        break;
                    }
                        
                }
                pos++;
            }

            if(anotherSubOne == "")
            {
                return subOperacion;
            }

            if(anotherSubTwo == "")
            {
                anotherSubTwo = subOperacion.Substring(posTwo);
                subOperacion = Operar(anotherSubOne, anotherSubTwo, subOperacion[posTwo - 1]);
            }
            else
            {
                subOperacion = Operar(anotherSubOne, anotherSubTwo, subOperacion[posTwo - 1]) + subOperacion.Substring(posLast);
            }

            
            return RealizarOperacion(subOperacion);
        }

        public string Operar(string numberOne, string numberTwo, char Operation)
        {
            double one = double.Parse(numberOne);
            double two = double.Parse(numberTwo);

            switch (Operation)
            {
                case '+':
                    return (one + two).ToString();
                case '*':
                    return (one * two).ToString();
                case '/':
                    return (one / two).ToString();
                case '-':
                    return (one - two).ToString();
                case '^':
                    return (Math.Pow(one,two)).ToString();
            }
            return numberOne;

        }
    }
}
