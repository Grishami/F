using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public int Dofac (int n)
        {
            int f = 1;

            for (int nn = n; nn >= 1; nn--)
                f = f * nn;

            return f;
            

        }
    }
}
