using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StratergyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Parameter> parameters = new List<Parameter>();
            AddParameters(parameters);
            VerifyParameterlist(parameters);

        }

        private static void VerifyParameterlist(List<Parameter> parameters)
        {
            Dictionary<string, VerifyParameters> functionlist;
            //substitution of startergy is defined at run time
            IntilializeDictionary(out functionlist);

            foreach (var parameter in parameters)
            {
                if (functionlist.ContainsKey(parameter.GetType()))
                {
                    functionlist[parameter.GetType()].VerifyParameter(parameter);
                }
            }
        }

        private static void IntilializeDictionary(out Dictionary<string, VerifyParameters> verifyfunction)
        {
            verifyfunction = new Dictionary<string, VerifyParameters>();
            verifyfunction["Integer"] = new VerifyIntegerParameter();
            verifyfunction["String"] = new VerifyStringParameter();
        }

        private static void AddParameters(List<Parameter> parameters)
        {
            StringParameter str = new  StringParameter("Name","String");
            str.SetValue("Apoorva");
            StringParameter str2 = new StringParameter("ID", "String");
            str2.SetValue("BK23456");
            IntegerParameter integer = new IntegerParameter("Marks","Integer");
            integer.SetValue("98");

            parameters.Add(str);
            parameters.Add(str2);
            parameters.Add(integer);
        }
    }
}
