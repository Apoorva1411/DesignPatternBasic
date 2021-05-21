using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            string buffer = String.Empty;
            Streamer memory = new MemoryStreamer();
            Streamer httpstream = new NetworkStreamer();
            Streamer file = new FileStreamer();
            //Streamer with decorator to read from chunk rather than byte by byte
            Streamer tcpstreamer = new BufferStreamer(new NetworkStreamer());

            memory.Read(buffer);
            httpstream.Read(buffer);
            file.Read(buffer);
            tcpstreamer.Read(buffer);

        }
    }
}
