using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StratergyPattern
{
   //Classes to create different type of parameter
    public class Parameter
    {
        private string name;
        private string type;
        private string value;

        public Parameter(string _name, string _type)
        {
            name = _name;
            type = _type;
        }
        public string GetName()
        {
            return name;
        }

        public string GetType()
        {
            return type;
        }
        public string GetValue()
        {
            return value;
        }

        public void SetValue(string val)
        {
            value = val;
        }
    }
    public class StringParameter : Parameter
    {
        public StringParameter(string name, string type) : base(name, type){}
    }
    public class IntegerParameter : Parameter
    {
        public IntegerParameter(string name, string type) : base(name, type) { }
    }
}
