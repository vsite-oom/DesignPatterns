using System;
using System.IO;

namespace DesignPatterns.Bridge
{
    interface IWriterImplementation
    {
        void WriteName(string name);
        void WriteAddress(string address);
    }

    class XmlPersonWriter : IWriterImplementation, IDisposable
    {
        public XmlPersonWriter(string filename)
        {
            streamWriter = new StreamWriter(filename);
            streamWriter.Write("<doc>");
        }

        StreamWriter streamWriter;

        public void WriteName(string name)
        {
            streamWriter.Write($"<name>{name}</name>");
        }

        public void Dispose()
        {
            streamWriter.Write("</doc>");
            streamWriter.Close();
        }

        public void WriteAddress(string address)
        {
            streamWriter.Write($"<address>{address}</address>");
        }
    }
    class TextWriter : IWriterImplementation, IDisposable
    {
        private StreamWriter streamWriter;

        public TextWriter(string filename)
        {
            streamWriter = new StreamWriter(filename);
        }

        public void WriteName(string name)
        {
            streamWriter.WriteLine($"Name: {name}");
        }

        public void WriteAddress(string address)
        {
            streamWriter.WriteLine($"Address: {address}");
        }

        public void Dispose()
        {
            streamWriter.Dispose();
        }
    }
}
