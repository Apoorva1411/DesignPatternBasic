using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    //Model which contains patient data
    public class PatientDataModel
    {
        public PatientDataModel(string name, string Mrn, string mail)
        {
            Name = name;
            MRN = Mrn;
            email = mail;
        }
        public string Name;

        public string MRN;

        public string email;
    }
}
