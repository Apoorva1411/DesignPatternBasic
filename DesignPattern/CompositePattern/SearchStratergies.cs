using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public interface ISearchStratergies
    {
        List<PatientDataModel> SearchPatient(List<PatientDataModel> patients);
    }


    public class SearchByName : ISearchStratergies
    {
        private string name;

        public SearchByName(string _name)
        {
            name = _name;
        }
        public List<PatientDataModel> SearchPatient(List<PatientDataModel> patients)
        {
            var patientlist = patients.Where(x => x.Name == name);
            return patientlist.ToList();
        }
    }

    public class SearchByMRN : ISearchStratergies
    {
        private string mrn;

        public SearchByMRN(string _mrn)
        {
            mrn = _mrn;
        }
        public List<PatientDataModel> SearchPatient(List<PatientDataModel> patients)
        {
            var patientlist = patients.Where(x => x.MRN == mrn);
            return patientlist.ToList();
        }
    }
    public class SearchByMail : ISearchStratergies
    {
        private string email;

        public SearchByMail(string _mail)
        {
            email = _mail;
        }
        public List<PatientDataModel> SearchPatient(List<PatientDataModel> patients)
        {
            var patientlist = patients.Where(x => x.email == email);
            return patientlist.ToList();
        }
    }

    //Composite Startergy contains other stratergy
    public class SearchStartergy : ISearchStratergies
    {

        private Dictionary<string, Type> stratergies;
        private Dictionary<string, string> inputs;
        public SearchStartergy(Dictionary<string, string> _input)
        {
            inputs = _input;
            AddStratergy();
        }
      
        public void AddStratergy()
        {
            stratergies = new Dictionary<string, Type>();
            stratergies.Add("MRN",typeof(SearchByMRN));
            stratergies.Add("Name",typeof(SearchByName));
            stratergies.Add("Mail",typeof(SearchByMail));
        }
        public List<PatientDataModel> SearchPatient(List<PatientDataModel> patients)
        {
            var patientlist = patients;
            foreach (var input in inputs)
            {
                if (stratergies.ContainsKey(input.Key))
                {
                    ISearchStratergies obj = Activator.CreateInstance(stratergies[input.Key],input.Value) as ISearchStratergies;
                    patientlist = obj.SearchPatient(patientlist);

                }
            }

            return patientlist;
        }
    }
}
