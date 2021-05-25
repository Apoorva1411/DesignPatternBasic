using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            InternetProxyGateway proxy = new InternetProxyGateway();
            WorkStation wrkstation = new WorkStation(proxy);
            wrkstation.Browse("www.google.com");
            wrkstation.Browse("www.youtube.com");
        }
    }
}
