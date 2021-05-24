using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public interface IProgramParadigm
    {
       string GetParadigm();
    }

    public class ObjectOriented : IProgramParadigm
    {
        private string name = "Object Oriented";
        public string GetParadigm()
        {
            return name;
        }
    }
    public class Prodecural : IProgramParadigm
    {
        private string name = "Procedure oriented";
        public string GetParadigm()
        {
            return name;
        }
    }

    public class ParadigmList : IProgramParadigm
    {
        private List<IProgramParadigm> paradigmlist;

        public ParadigmList()
        {
            paradigmlist = new List<IProgramParadigm>();
            paradigmlist.Add(new ObjectOriented());
            paradigmlist.Add(new Prodecural());
        }
        public string GetParadigm()
        {
            List<string> paradigms = new List<string>();
            foreach (var paradigm in paradigmlist)
            {
                var temp = paradigm.GetParadigm();
                paradigms.Add(temp);
            }

            return String.Join(" and  ", paradigms);
        }
    }
}
