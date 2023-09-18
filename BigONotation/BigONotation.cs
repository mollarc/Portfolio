using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BigONotation
{
    internal class BigONotation
    {
        BigONotation()
        {

        }

        /*
         *This method is constant or O(1) because this method only requires one step regardless of input
         */
        public void OConstant()
        {
            Console.WriteLine("Hello World!");
        }

        /*
         * This method runs in O(n) because it steps n times where n is a positive number
         */
        public void OLinear(int n)
        {
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine(i);
            }
        }

        /*
         * This method runs in O(n^2) because the inner loop runs n1 times of n2 times of the outer loop if both n1 and n2 are postive numbers
         */
        public void OQuadratic(int n1, int n2)
        {
            for(int i = 0;i < n1;i++)
            {
                Console.WriteLine(i);
                for (int j = 0;j < n2; j++)
                {
                    Console.WriteLine(j);
                }
            }
        }
    }
}
