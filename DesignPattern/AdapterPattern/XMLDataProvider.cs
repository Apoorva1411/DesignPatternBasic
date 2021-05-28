using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public interface IXMLDataProvider
    {
        string GetContent();
    }
    public class XMLDataProvider : IXMLDataProvider
    {
        private string xmlcontent;
        public string GetContent()
        {
            return xmlcontent;
        }
    }
}
