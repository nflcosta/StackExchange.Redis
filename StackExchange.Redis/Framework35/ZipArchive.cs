#if NET35
using System;
using System.IO;

namespace StackExchange.Redis
{
    internal class ZipArchive : IDisposable
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        internal ZipArchiveEntry CreateEntry(string name, ZipArchiveMode optimal)
        {
            throw new NotImplementedException();
        }

        internal ZipArchiveEntry CreateEntry(string name, ZipArchiveMode optimal, bool value)
        {
            throw new NotImplementedException();
        }


    }

    internal class ZipArchiveEntry
    {
        public Stream Open()
        {
            throw new NotImplementedException();

        }
    }
}
#endif