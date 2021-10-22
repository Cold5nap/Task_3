using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class SweetComparerByName : IComparer<Sweet>
    {
        public int Compare(Sweet x, Sweet y)
        {
            if (x._name.CompareTo(y._name) > 0)
                return 1;
            else if (x._name.CompareTo(y._name) == 0)
                return 0;
            else
                return -1;
        }
    }
}
