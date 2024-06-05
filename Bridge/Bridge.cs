namespace DesignPatterns.Bridge
{
    class Writer : IDisposable
    {
        public Writer(string filename)
        {
            implementation = new TextWriter(filename);
        }

        private readonly IWriterImplementation implementation;

        public void WriteName(string name)
        {
            implementation.WriteName(name);
        }

        public void WriteAddress(string address)
        {
            implementation.WriteAddress(address);
        }

        public void Close()
        {
            var disposable = implementation as IDisposable;
            if (disposable != null)
            {
                disposable.Dispose();
            }
        }

        void IDisposable.Dispose()
        {
            Close();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            using (Writer w = new Writer("output.xml"))
            {
                w.WriteName("Pero");
                w.WriteAddress("Vlaška 8");
            }
        }
    }
}
