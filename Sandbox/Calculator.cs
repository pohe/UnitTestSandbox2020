using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public class Calculator
    {
        public Calculator()
        {
            
        }

        public int Add(int tal1, int tal2)
        {
            return tal1 + tal2;
        }

        public int Division(int tal1, int tal2)
        {
            if (tal2>100)
                throw new TooLargeNumberException("Tallet er for stort");
            return tal1 / tal2;
        }



    }
}
