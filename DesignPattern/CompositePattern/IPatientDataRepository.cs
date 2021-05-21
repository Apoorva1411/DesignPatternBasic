using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace CompositePattern
{
    //Interface for Data Repository to ensur we have dependency Inversion rule applied 
    public abstract class IPatientDataRepository
    {
        public abstract void AddPatientModel(PatientDataModel patient);
        public abstract List<PatientDataModel> GetAllPatients();

        public abstract bool RemovePatient(PatientDataModel patient);

        public abstract void ClearDataRepository();
    }

    //repository where data stored as List of aptients

    public class PatientDataRepository : IPatientDataRepository
    {
        private List<PatientDataModel> patientlist = new List<PatientDataModel>();

        public override void AddPatientModel(PatientDataModel patient)
        {
            patientlist.Add(patient);
        }

        public override void ClearDataRepository()
        {
           patientlist.Clear();
        }

        public override List<PatientDataModel> GetAllPatients()
        {
            return patientlist;
        }

        public override bool RemovePatient(PatientDataModel patient)
        {
            return patientlist.Remove(patient);
        }
    }

    public class NewPatientDataRepository : IPatientDataRepository
    {
        private int NoofPatient = 0;
        Dictionary<PatientDataModel,int> patients = new Dictionary<PatientDataModel,int>();
        public override void AddPatientModel(PatientDataModel patient)
        {
            patients[patient] = NoofPatient++;
        }

        public override void ClearDataRepository()
        {
           patients.Clear();
        }

        public override List<PatientDataModel> GetAllPatients()
        {
            return patients.Keys.ToList();
        }

        public override bool RemovePatient(PatientDataModel patient)
        {
            return patients.Remove(patient);
        }
    }
}
