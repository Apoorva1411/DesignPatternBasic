using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public interface FirmWareActivity
    {
        void Execute();
        void SetSuccessor(FirmWareActivity successor);
    }

    public class Activity1 : FirmWareActivity
    {
        private FirmWareActivity successor;
        public void Execute()
        {
            Console.WriteLine("Execute Activity1");
            successor?.Execute();
        }

        public void SetSuccessor(FirmWareActivity _successor)
        {
            successor = _successor;
        }
    }

    public class Activity2 : FirmWareActivity
    {
        private FirmWareActivity successor;
        public void Execute()
        {
            Console.WriteLine("Execute Activity2");
            successor?.Execute();
        }

        public void SetSuccessor(FirmWareActivity _successor)
        {
            successor = _successor;
        }
    }

    public class Activity3 : FirmWareActivity
    {
        private FirmWareActivity successor;
        public void Execute()
        {
            Console.WriteLine("Execute Activity3");
            successor?.Execute();
        }

        public void SetSuccessor(FirmWareActivity _successor)
        {
            successor = _successor;
        }
    }

    public class Activity4 : FirmWareActivity
    {
        private FirmWareActivity successor;
        public void Execute()
        {
            Console.WriteLine("Execute Activity4");
            successor?.Execute();
        }

        public void SetSuccessor(FirmWareActivity _successor)
        {
            successor = _successor;
        }
    }
}
