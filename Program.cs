
using ProxyDesignPattern;

Console.WriteLine("Proxy Design Pattern");

ProxyClient proxy = new ProxyClient();
Console.WriteLine("Data from Proxy Client = {0}", proxy.GetData());

Console.ReadKey();
