using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public abstract class Streamer
    {
        private string bufferclass;
        public abstract void Read(string bufferclass);
        public abstract void Write(string bufferclass);

    }

    public class FileStreamer : Streamer
    {
        public override void Read(string bufferclass)
        {
            Console.WriteLine("Reading data byte by byte to buffer");
        }

        public override void Write(string bufferclass)
        {
            Console.WriteLine("Writing  data byte by byte");
        }
    }

    public class MemoryStreamer : Streamer
    {
        public override void Read(string bufferclass)
        {
            Console.WriteLine("Reading data byte by byte to buffer");
        }

        public override void Write(string bufferclass)
        {
            Console.WriteLine("Writing  data byte by byte");
        }
    }

    public class NetworkStreamer : Streamer
    {
        public override void Read(string bufferclass)
        {
            Console.WriteLine("Reading data byte by byte to buffer");
        }

        public override void Write(string bufferclass)
        {
            Console.WriteLine("Writing  data byte by byte");
        }
    }

    //decorator class to read data in chunks rather than byte by byte
    public class BufferStreamer : Streamer
    {
        private Streamer streamer;
        private String buffer;

        public BufferStreamer(Streamer target)
        {
            streamer = target;
        }
        public void ReadStreamerBufferData(string buffer)
        {
            //read stream data and return value
        }
      

        public override void Read(string bufferclass)
        {
            Console.WriteLine("Reading from Chunk");
            ReadStreamerBufferData(buffer);
        }

        public override void Write(string bufferclass)
        {
           
            streamer.Write(bufferclass);
        }
    }
}
