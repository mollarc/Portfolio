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

        public void OConstant()
        {
            Console.WriteLine("Hello World!");
        }

        public void OLinear(int n)
        {
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine(i);
            }
        }

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
