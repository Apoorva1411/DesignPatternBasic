using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StratergyPattern
{
    //definition of Interface for stratergies
    public abstract class VerifyParameters
    {
        public abstract bool VerifyParameter(Parameter p);
    }

    public class VerifyStringParameter : VerifyParameters
    {
        public override bool VerifyParameter(Parameter p)
        {
            string value = p.GetValue();
            if (value.Length > 0)
            {
                Console.WriteLine("Valid Parameter");
                return true;
            }

            return false;
        }
    }

    public class VerifyIntegerParameter : VerifyParameters
    {
        public override bool VerifyParameter(Parameter p)
        {
            string value = p.GetValue();
            int param_value = Int32.Parse(value);
            if (param_value > 0)
            {
                Console.WriteLine("Integer is valid");
                return true;
            }

            return false;
        }
    }
}
