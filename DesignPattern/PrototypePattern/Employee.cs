using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    //prototype interface which can be implemented to support Object cloning
    public interface IEmployee
    {
        object Clone();
        string GetDetails();
    
    }

    public class Developer : IEmployee
    {
        public string Name;
        public string Designation;
        public string ID;

        public Developer(string name, string desg, string id)
        {
            Name = name;
            Designation = desg;
            ID = id;
        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public string GetDetails()
        {
            return string.Format("{0} - {1} - {2}", Name, ID, Designation);
        }
    }

    public class Tester : IEmployee
    {
        private string Name;
        private string Designation;
        private string ID;

        public Tester(string name, string desg, string id)
        {
            Name = name;
            Designation = desg;
            ID = id;
        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public string GetDetails()
        {
            return string.Format("{0} - {1} - {2}", Name, ID, Designation);
        }
    }

    public class HREmployee : IEmployee
    {
        private string Name;
        private string Designation;
        private string ID;

        public HREmployee(string name, string desg, string id)
        {
            Name = name;
            Designation = desg;
            ID = id;
        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public string GetDetails()
        {
            return string.Format("{0} - {1} - {2}", Name, ID, Designation);
        }
    }
}
