using System;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public abstract class ISubscriber
    {
        public IEventAggregator eventagg;

        public abstract void Update();
        public ISubscriber(IEventAggregator _event)
        {
            eventagg = _event;
        }
    }

    public class ModuleA : ISubscriber
    {
        private string _name;

        public ModuleA(IEventAggregator _event) : base(_event)
        {
            eventagg.Subscribe("E2",this);
        }

        public string Name
        {
            get { return _name;}
            set
            {
                _name = value; 
                eventagg.Publish("E1");
            }
        }

        public override void Update()
        {
            Console.WriteLine("Received Notification in Module A");
        }
    }

    public class ModuleB : ISubscriber
    {
        private string _name;

        public ModuleB(IEventAggregator _event) : base(_event)
        {
            eventagg.Subscribe("E1",this);
        }

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value; 
                eventagg.Publish("E2");
            }
        }
        public override void Update()
        {
            Console.WriteLine("Received Notification in Module B");
        }

    }

    public class ModuleC : ISubscriber
    {
        private string _name;

        public ModuleC(IEventAggregator _event) : base(_event)
        {
            eventagg.Subscribe("E1",this);
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public override void Update()
        {
            Console.WriteLine("Received Notification in Module C");
        }

    }
}
