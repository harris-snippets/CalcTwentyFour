using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcLibrary
{
    public class TwentyFourManager
    {
        public TwentyFourManager()
        {
            Precision = 1e-6;
        }

        public IEnumerable<string> Calculate(int num1, int num2, int num3, int num4)
        {
            number = new double[4];
            number[0] = num1;
            number[1] = num2;
            number[2] = num3;
            number[3] = num4;

            expression = new string[4];
            expression[0] = num1.ToString();
            expression[1] = num2.ToString();
            expression[2] = num3.ToString();
            expression[3] = num4.ToString();

            return Calculate2(4).AsEnumerable();
        }

        double Precision;
        double[] number;
        string[] expression;

        List<string> Calculate2(int n)
        {
            List<string> result = new List<string>();
            if (n == 1)
            {
                if (Math.Abs(number[0] - 24) < Precision)
                    result.Add(expression[0]);
                return result;
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    double a, b;
                    string expa, expb;

                    a = number[i];
                    b = number[j];
                    number[j] = number[n - 1];

                    expa = expression[i];
                    expb = expression[j];
                    expression[j] = expression[n - 1];

                    expression[i] = "(" + expa + '+' + expb + ")";
                    number[i] = a + b;
                    result.AddRange(Calculate2(n - 1));

                    expression[i] = "(" + expa + '-' + expb + ")";
                    number[i] = a - b;
                    result.AddRange(Calculate2(n - 1));

                    expression[i] = "(" + expb + '-' + expa + ")";
                    number[i] = b - a;
                    result.AddRange(Calculate2(n - 1));


                    expression[i] = "(" + expa + '*' + expb + ")";
                    number[i] = a * b;
                    result.AddRange(Calculate2(n - 1));

                    if (b != 0)
                    {
                        expression[i] = "(" + expa + '/' + expb + ")";
                        number[i] = a / b;
                        result.AddRange(Calculate2(n - 1));
                    }
                    if (a != 0)
                    {
                        expression[i] = "(" + expb + '/' + expa + ")";
                        number[i] = b / a;
                        result.AddRange(Calculate2(n - 1));
                    }

                    number[i] = a;
                    number[j] = b;
                    expression[i] = expa;
                    expression[j] = expb;
                }
            }
            return result;
        }
    }
}
