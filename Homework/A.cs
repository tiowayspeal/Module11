using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    interface I1
    {
        void M();
    }

    interface I2
    {
        void M();
    }

    class A : I1, I2
    {
       void I1.M() { Console.WriteLine("I1.A.M()"); } // I1 i1 = new A(); i1.M();
       void I2.M() { Console.WriteLine("I2.A.M()"); } // I2 i2 = new A(); i2.M();
       
    }

}