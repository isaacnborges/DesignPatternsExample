namespace Singleton_1
{
    internal class Server
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Ip { get; set; }

        public Server(Guid id, string name, string ip)
        {
            Id = id;
            Name = name;
            Ip = ip;
        }
    }
}
