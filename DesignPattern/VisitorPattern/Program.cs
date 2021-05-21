using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
           List<IShape> shapes = new List<IShape>() { new Circle(), new Rectangle(),new Square()};
           Picture image = new Picture(shapes);
           image.DrawAll();
        }
    }
}
