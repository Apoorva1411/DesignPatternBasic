using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public interface IShape
    {
        void Draw(IPrinter p);
    }
    
    public class Circle : IShape
    {
        public void Draw(IPrinter p)
        {
            p.Print(this);
        }
    }
    public class Square : IShape
    {
        public void Draw(IPrinter p)
        {
            p.Print(this);
        }
    }

    public class Rectangle : IShape
    {
        public void Draw(IPrinter p)
        {
            p.Print(this);
        }
    }

}
