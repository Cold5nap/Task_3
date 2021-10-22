using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class ChocolateBarComparerByMaterial : IComparer<ChocolateBar>
    {
        public int Compare(ChocolateBar x, ChocolateBar y)
        {
            if (x._weightOfChocolate < y._weightOfChocolate)
                return -1;
            else if (x._weightOfChocolate == y._weightOfChocolate)
                return 0;
            else
                return 1;
        }
    }
}
