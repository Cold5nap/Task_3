using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    abstract class SweetWithChocolate:Sweet
    {
        public double _weightOfChocolate { get; set; }
        public SweetWithChocolate(string name, double weight, double weightOfSugar, double weightOfChocolate)
            : base(name, weight, weightOfSugar)
        {
            _weightOfChocolate = weightOfChocolate;
        }
        public override String ToString()
        {
            return _name + " " + _weight + " " + _weightOfSugar + " " + _weightOfChocolate + " ";
        }
    }
}
