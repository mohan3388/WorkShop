using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShopProblem
{
   public class Problem
    {
        public void HarmonicNumber()
        {
            double a = 0.0, i;
            Console.WriteLine("enter number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                a = a + 1 / i;
                Console.WriteLine($"1/{i}+");
            }

        }
    }
}
