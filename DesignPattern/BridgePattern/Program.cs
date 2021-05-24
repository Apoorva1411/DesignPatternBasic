using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ILanguage> languages = new List<ILanguage>();
            AddLanguages(languages);

            foreach (var lang in languages)
            {
               lang.GetUnit();
            }

        }

        private static void AddLanguages(List<ILanguage> languages)
        {
            IProgramParadigm paradigm = new ParadigmList();
            ILanguage CPlus = new Cplusplus(paradigm);
            languages.Add(CPlus);

            IProgramParadigm paradigm1 = new ObjectOriented();
            ILanguage CSharp = new CSharp(paradigm1);
            languages.Add(CSharp);

            IProgramParadigm paradigm2 = new Prodecural();
            ILanguage python = new Python(paradigm2);
            languages.Add(python);
        }
    }
}
