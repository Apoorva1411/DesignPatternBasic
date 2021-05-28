using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AdapterPattern
{
    public interface IJsonProvider
    {
        string GetContent();
    }
    public class JsonProvider : IJsonProvider
    {
        private XMLDataProvider xmldata;
        private string JsonContent;

        public JsonProvider(string content)
        {
            xmldata = new XMLDataProvider();
            JsonContent = content;
        }
        public string GetContent()
        {
            string xldata = xmldata.GetContent();
            string content = ConvertToJSON(xldata);
            return content;
        }

        private string ConvertToJSON(string xldata)
        {
            //Function to convert XML to JSON object
            return String.Empty;
        }
    }
}
