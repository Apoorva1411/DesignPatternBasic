using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern.cs
{
    public interface Gateway
    {
        void AcceptRequest(string url);
    }

    public class InternetProxyGateway : Gateway
    {
        private List<string> whitelistUrl;
        private List<string> blacklistUrl;
        private InternetGateway gateway;

        public InternetProxyGateway()
        {
            gateway = new InternetGateway();
            whitelistUrl = new List<string>();
            whitelistUrl.Add("www.google.com");
            blacklistUrl = new List<string>();
            blacklistUrl.Add("www.youtube.com");
        }

        public void AcceptRequest(string url)
        {
            if (whitelistUrl.Contains(url))
            {
                gateway.AcceptRequest(url);

            }
            else if (blacklistUrl.Contains(url))

            {
                Console.WriteLine("Url browsing blocked");
            }
        }
    }

    public class InternetGateway : Gateway
    {
        public void AcceptRequest(string url)
        {
            Console.WriteLine("Browsing URL : " + url);
        }
    }
}

