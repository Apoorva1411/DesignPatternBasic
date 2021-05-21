using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    /// <summary>
    /// visitor class to be changed when we add new shape
    /// </summary>
    public interface IPrinter
    {
        void Print(Rectangle S);
        void Print(Square S);
        void Print(Circle S);
    }
    public class DotMatrixPrinter : IPrinter
    {
        private String type;

        public void Print(Circle S)
        {
            Console.WriteLine("Printing Circle using DotMatrixPrinter");
        }

        public void Print(Square S)
        {
            Console.WriteLine("Printing Square using DotMatrixPrinter");
        }

        public void Print(Rectangle S)
        {
            Console.WriteLine("Printing Rectangle using DotMatrixPrinter");
        }

      
    }
    public class InkJet : IPrinter
    {
        public void Print(Circle S)
        {
            Console.WriteLine("Printing Circle using InkJet");
        }

        public void Print(Square S)
        {
            Console.WriteLine("Printing Square using InkJet");
        }

        public void Print(Rectangle S)
        {
            Console.WriteLine("Printing Rectangle using InkJet");
        }

    }
    public class LaserPrinter : IPrinter
    {
        public void Print(Circle S)
        {
            Console.WriteLine("Printing Circle using LaserPrinter");
        }

        public void Print(Square S)
        {
            Console.WriteLine("Printing Square using LaserPrinter");
        }

        public void Print(Rectangle S)
        {
            Console.WriteLine("Printing Rectangle using LaserPrinter");
        }
    }

    public class Printers : IPrinter
    {
        List<IPrinter> printList = new List<IPrinter>();

        public Printers()
        {
            printList.Add(new InkJet());
            printList.Add(new DotMatrixPrinter());
            printList.Add(new LaserPrinter());
        }
        public void Print(Circle S)
        {
            foreach (var printer in printList)
            {
               printer.Print(S);
            }
        }

        public void Print(Square S)
        {
            foreach (var printer in printList)
            {
                printer.Print(S);
            }
        }

        public void Print(Rectangle S)
        {
            foreach (var printer in printList)
            {
                printer.Print(S);
            }
        }
    }

}
