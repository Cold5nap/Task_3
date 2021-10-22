using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class ChocolateBar:SweetWithChocolate
    {
        public ChocolateBar(string name, double weight, double weightOfSugar, double weightOfCaramel)
            : base(name,weight, weightOfSugar, weightOfCaramel)
        {
        }
    }
}
