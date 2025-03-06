using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TargetSolutions.src.Desafios
{
    public class Questao2
    {
        public static bool PertenceFibonacci(int num)
        {
            int a = 0, b = 1, temp;

            while (a <= num)
            {
                if (a == num)
                    return true;

                temp = a + b;
                a = b;
                b = temp;
            }

            return false;
        }
    }
}