using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class Window : IButtonObserver
    {
        public TextBox txt = new TextBox();
        public Button btn = new Button();

        public Window()
        {
            btn.Subscribe(this);
        }
       
        public void Notify()
        {
            txt.ClearTextBox();
        }
    }
}
