using System.Net; // IPHostEntry, Dns, IPAddress
using static System.Console;
using System.Net.NetworkInformation; // Ping, PingReply, IPStatus

Write("Enter a valid web address: ");
string? url = ReadLine();

if (string.IsNullOrWhiteSpace(url))
{
    url = "https://stackoverflow.com/search?q=securestring";
}

Uri uri = new(url);

WriteLine($"URL: {url}");
WriteLine($"Scheme: {uri.Scheme}");
WriteLine($"Port: {uri.Port}");
WriteLine($"Host: {uri.Host}");
WriteLine($"Path: {uri.AbsolutePath}");
WriteLine($"Query: {uri.Query}");

IPHostEntry entry = Dns.GetHostEntry(uri.Host);
WriteLine($"{entry.HostName} has the following IP Addresses:");
foreach (IPAddress address in entry.AddressList)
{
    WriteLine($"   {address} ({address.AddressFamily})");
}

try
{
    Ping ping = new();
    WriteLine("Pinging server. Please wait...");
    PingReply reply = ping.Send(uri.Host);

    WriteLine($"{uri.Host} was pinged and replied: {reply.Status}.");
    if (reply.Status == IPStatus.Success)
    {
        WriteLine("Reply from {0} took {1:N0}ms", reply.Address, reply.RoundtripTime);
    }
}
catch (Exception ex)
{
    WriteLine($"{ex.GetType().ToString()} says {ex.Message}");
}