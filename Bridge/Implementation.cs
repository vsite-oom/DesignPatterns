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

    // TODO: 2.1 Create a simple text writer that implements IWriterImplementation interface and replace XmlPersonWriter in Writer class with the new class.
}
