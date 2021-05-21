using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class PatientSearchService
    {
        static void Main(string[] args)
        {
            IPatientDataRepository patientData = new PatientDataRepository();
            AddPatients(patientData);
            Dictionary<string,string> SearchPattern = new Dictionary<string, string>();
            SearchPattern.Add("Name","Apoorva");
            SearchPattern.Add("Mail", "apoorvaraju@email.com");
            //Sent multiple search pattern to service
            ISearchStratergies stratergy = new SearchStartergy(SearchPattern);
            List<PatientDataModel> result = stratergy.SearchPatient(patientData.GetAllPatients());
        }

        private static void AddPatients(IPatientDataRepository patientData)
        {
            patientData.AddPatientModel(new PatientDataModel("Apoorva","1234","apoorva@email.com"));
            patientData.AddPatientModel(new PatientDataModel("Apoorva", "123543", "apoorvaraju@email.com"));
            patientData.AddPatientModel(new PatientDataModel("TestPatient", "123543", "patientname@email.com"));
            patientData.AddPatientModel(new PatientDataModel("TestPatient2", "123543", "patientname@email.com"));
        }
    }
}
