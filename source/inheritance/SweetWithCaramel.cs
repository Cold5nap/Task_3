using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    abstract class SweetWithCaramel:Sweet
    {
        public double _weightOfCaramel { get; set; }
        public SweetWithCaramel(string name, double weight,double weightOfSugar,double weightOfCaramel)
            :base(name,weight,weightOfSugar)
        {
            _weightOfCaramel = weightOfCaramel;
        }
        public override String ToString()
        {
            return _name + " " + _weight + " " + _weightOfSugar + " "+_weightOfCaramel+" ";
        }
    }
}
