using System;

namespace testprogram
{
    public interface IPrinter
    {
        void Print();
    }
    public interface IScanner
    {
        void Scan();
    }

    public class Printer : IPrinter
    {
        public void Print()
        {
            Console.WriteLine("Printing......");
        }
    }
    public class Scanner : IScanner
    {
        public void Scan()
        {
            Console.WriteLine("Scanning......");
        }
    }

    public class PrintScanner : IPrinter, IScanner
    {
        IPrinter _print = new Printer();
        IScanner _scan = new Scanner();
        public void Print()
        {
            _print.Print();
        }

        public void Scan()
        {
            _scan.Scan();
        }
    }
    public class PrintManager
    {
        private IPrinter _print;

         public PrintManager(IPrinter print)
         {
             _print = print;
         }

         public void Print()
         {
             _print.Print();
         }
    }

    public class ScanManager
    {
        private IScanner _scan;
        public ScanManager(IScanner scan)
        {
            _scan = scan;
        }

        public void Scan()
        {
            _scan.Scan();
        }
    }
    class Program
    { 
        static void Main(string[] args)
        {
            PrintManager pm = new PrintManager(new Printer());
            pm.Print();
            ScanManager sm = new  ScanManager(new Scanner());
            sm.Scan();
            pm = new PrintManager(new PrintScanner());
            pm.Print();
            sm = new ScanManager(new PrintScanner());
            sm.Scan();
        }
    }
}
