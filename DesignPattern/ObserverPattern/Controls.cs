using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public abstract class Controls
    {
        public string ID;
    }

    public class Button : Controls
    {
        private bool isClick;
        public List<IButtonObserver> observers;

        public Button()
        {
            observers = new List<IButtonObserver>();
        }
        public void Subscribe(IButtonObserver observer)
        {
            observers.Add(observer);
        }

        public void Unsubscribe(IButtonObserver observer)
        {
            observers.Remove(observer);
        }
        public void OnClick()
        {
            Console.WriteLine("On Button Click");
            foreach (var observer in observers)
            {
                observer.Notify();
            }

        }
    }

    public class TextBox : Controls
    {
        private string text; 
        public void ClearTextBox()
        {
            Console.WriteLine("Text Box is cleared");
        }
    }
}
