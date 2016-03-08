#if NET35
using System.Net;

namespace StackExchange.Redis
{
    internal class DnsEndPoint : EndPoint
    {
        public string Host { get; set; }
        public int Port { get; set; }
        public string AddressFamily { get; set; }

        public DnsEndPoint(string host, int port)
        {
            this.Host = host;
            this.Port = port;
        }

        public DnsEndPoint(string host, int port, string addressfamily)
        {
            this.Host = host;
            this.Port = port;
            this.AddressFamily = addressfamily;
        }
    }
}
#endif