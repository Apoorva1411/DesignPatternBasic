using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class HardDisk
    {
        public HardDisk()
        {

        }

        public void ReadData()
        {
            Console.WriteLine("Reading data from harddisk");
        }
    }

    public class Memory
    {
        public Memory()
        {

        }

        public void Load()
        {
            Console.WriteLine("Loading Memory Data");
        }
    }

    public class CPU
    {
        public CPU()
        {

        }

        public void ProcessData()
        {
            Console.WriteLine("Processing data....");
        }
    }

    public class Computer
    {
        private HardDisk _hd;
        private Memory _mry;
        private CPU _cpu;

        public Computer()
        {
            _hd = new HardDisk();
            _mry = new Memory();
            _cpu = new CPU();
        }

        //Facade to simplify computer start process
        public void Start()
        {
            _mry.Load();
            _hd.ReadData();
            _cpu.ProcessData();
        }

    }
    public class Program
    {
        static void Main(string[] args)
        {
            Computer comp = new Computer();

            comp.Start();
        }
    }
}
