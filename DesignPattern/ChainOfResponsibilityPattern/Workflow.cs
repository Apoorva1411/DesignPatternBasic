using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Workflow
    {
        private FirmWareActivity rootActivity;

        public void SetRootActivity(FirmWareActivity _root)
        {
            rootActivity = _root;
        }

        public void Start()
        {
            rootActivity.Execute();
        }
    }
}
