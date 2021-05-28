using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Developer developer = new Developer("ABC","Software Engg","1234");
            //Object can been clone rather than creating new object everytime
            Developer developer2 = developer.Clone() as Developer;

            developer2.Name = "CDF";
            developer2.Designation = "Arhitect";
            developer2.ID = "345673";
            Console.WriteLine(developer.GetDetails());
            Console.WriteLine(developer2.GetDetails());



        }
    }
}
