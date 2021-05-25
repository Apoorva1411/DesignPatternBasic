using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Window window = new Window();
            //mocking the button click on UI
            window.btn.OnClick();
        }
    }
}
