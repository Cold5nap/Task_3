using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class CandyComparerByMaterial : IComparer<Candy>
    {
        public int Compare(Candy x, Candy y)
        {
            if (x._weightOfCaramel < y._weightOfCaramel)
                return -1;
            else if (x._weightOfCaramel == y._weightOfCaramel)
                return 0;
            else
                return 1;
        }
    }
}
