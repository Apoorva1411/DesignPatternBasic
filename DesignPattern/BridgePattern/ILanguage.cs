using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public abstract class ILanguage
    {
        protected IProgramParadigm paradigm;

        public ILanguage(IProgramParadigm _paradigm)
        {
            paradigm = _paradigm;
        }
        public abstract void GetUnit();
    }

    public class CSharp : ILanguage
    {
        public CSharp(IProgramParadigm _paradigm) : base(_paradigm)
        {
        }

        public override void GetUnit()
        {
            Console.WriteLine("C# Language supports " + paradigm.GetParadigm() + " paradigm");
        }
    }

    public class Python : ILanguage
    {
        public Python(IProgramParadigm _paradigm) : base(_paradigm)
        {
        }

        public override void GetUnit()
        {
            Console.WriteLine("Python Language supports " + paradigm.GetParadigm() + " paradigm");
        }
    }

    public class Cplusplus : ILanguage
    {
        public Cplusplus(IProgramParadigm _paradigm) : base(_paradigm)
        {
        }

        public override void GetUnit()
        {
            Console.WriteLine("C++ Language supports " + paradigm.GetParadigm() + " paradigm");
        }
    }
}
