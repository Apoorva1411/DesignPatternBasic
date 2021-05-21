using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Workflow workflow = new Workflow();
            FirmWareActivity activity1 = new Activity1();
            FirmWareActivity activity2 = new Activity2();
            FirmWareActivity activity3 = new Activity3();
            FirmWareActivity activity4 = new Activity4();

            //Chaining task can be done dynamically
            workflow.SetRootActivity(activity1);
            activity1.SetSuccessor(activity4);
            activity4.SetSuccessor(activity3);
            activity3.SetSuccessor(activity2);
            workflow.Start();

        }
    }
}

