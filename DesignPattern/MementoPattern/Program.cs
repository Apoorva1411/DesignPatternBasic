using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBoxContent
{


    public class TextBoxEditor
    { 
        private Stack<string> RewindString;
        public TextBoxEditor()
        {
            RewindString = new Stack<string>();
        }

        internal void AddString(string _content)
        {
            RewindString.Push(_content);
        }

        internal string GetString()
        {
            return RewindString.Pop();
        }
    }

    public class TextBox
    {
        private string _content;
        TextBoxEditor txteditor;

        public TextBox()
        {
            txteditor = new TextBoxEditor();
            _content = string.Empty;
        }

        public void OnTextBoxChange(string val)
        {
            txteditor.AddString(_content);
            _content = val;
        }

        public void print()
        {
            Console.WriteLine("Value :" + _content);
        }

        public void undo()
        {
            _content = txteditor.GetString();
        }
}
    class Program
    {
        static void Main(string[] args)
        {
            TextBox txt = new TextBox();
    
            while (true)
            {
                Console.WriteLine("1.Change\n2.Undo\n3.Print\n ");
                int choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter value");
                        txt.OnTextBoxChange(Console.ReadLine());
                         break;
                    case 2: 
                        txt.undo();
                        break;
                    case 3:
                            txt.print();
                            break;
                }
            }
        }
    }
}
