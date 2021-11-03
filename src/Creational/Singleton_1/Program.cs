using Singleton_1;

Console.WriteLine("*** Singleton 1 ***");
Console.WriteLine();

var balancer1 = LoadBalancerSingleton.GetLoadBalancer();
var balancer2 = LoadBalancerSingleton.GetLoadBalancer();
var balancer3 = LoadBalancerSingleton.GetLoadBalancer();
var balancer4 = LoadBalancerSingleton.GetLoadBalancer();

if (balancer1 == balancer2 && 
    balancer2 == balancer3 && 
    balancer3 == balancer4)
{
    Console.WriteLine("Mesma instância\n");
}

var balancer = LoadBalancerSingleton.GetLoadBalancer();

for (var i = 0; i < 15; i++)
{
    var serverName = balancer.NextServer.Name;
    Console.WriteLine("Disparando request para: " + serverName);
}