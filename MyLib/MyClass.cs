using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    /// <summary>
    /// The class to perform tests on.
    /// </summary>
    public class MyClass
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public decimal Divide(decimal a, decimal b)
        {
            if (b == 0) throw new ArgumentException("The b argument cannot be null", "b");
            return a / b;
        }
    }
}
