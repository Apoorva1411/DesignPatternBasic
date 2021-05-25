using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern.cs
{
    public class WorkStation
    {
        public Gateway _gateway;

        public WorkStation(Gateway gateway)
        {
            _gateway = gateway;
        }
        public void Browse(string url)
        {
            _gateway.AcceptRequest(url);
        }

    }
}
