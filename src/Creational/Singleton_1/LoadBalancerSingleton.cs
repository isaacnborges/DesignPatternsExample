namespace Singleton_1
{
    internal sealed class LoadBalancerSingleton
    {
        private static readonly LoadBalancerSingleton Intance = new();

        private readonly List<Server> _servers;
        private readonly Random _random = new();

        private LoadBalancerSingleton()
        {
            _servers = new List<Server>
            {
                 new Server(Guid.NewGuid(), "Server_I", "120.14.220.18"),
                 new Server(Guid.NewGuid(), "Server_II", "120.14.220.19"),
                 new Server(Guid.NewGuid(), "Server_III", "120.14.220.20"),
                 new Server(Guid.NewGuid(), "Server_IV", "120.14.220.21"),
                 new Server(Guid.NewGuid(), "Server_V", "120.14.220.22"),
            };
        }

        public static LoadBalancerSingleton GetLoadBalancer()
        {
            return Intance;
        }

        public Server NextServer
        {
            get
            {
                var random = _random.Next(_servers.Count);
                return _servers[random];
            }
        }
    }
}
