using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class CommandTarget
    {
        public CommandTarget()
        {

        }

        public void Method()
        {
            Console.WriteLine("Triggered the Command");
        }
    }
}
