using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    abstract class Sweet
    {
        public string _name { get; set; }
        public double _weight { get; set; }
        public double _weightOfSugar { get; set; }
        public Sweet(string name,double weight, double weightOfSugar)
        {
            _weight = weight;
            _weightOfSugar = weightOfSugar;
            _name = name;

        }

        public abstract String ToString();
    }
}
