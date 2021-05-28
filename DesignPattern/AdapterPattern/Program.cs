using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            JsonProvider json = new JsonProvider("JSON");
            //fetches the xmldata and adapts it to JSON data
            var JsonContent = json.GetContent();
        }
    }
}
