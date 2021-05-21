using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public class Picture
    {
        private IPrinter printer;
        private List<IShape> shapes;

        public Picture(List<IShape> _shape)
        {
            shapes = _shape;
        }
        public void DrawAll()
        {
            IPrinter printer = new Printers();
            foreach (var shape in shapes)
            {
                shape.Draw(printer);
            }
        }

    }
}
