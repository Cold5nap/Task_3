using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class SweetComparerByWeight : IComparer<Sweet>
    {
        public int Compare(Sweet x, Sweet y)
        {
            if (x._weight < y._weight)
                return -1;
            else if (x._weight == y._weight)
                return 0;
            else
                return 1;
        }
    }
}
