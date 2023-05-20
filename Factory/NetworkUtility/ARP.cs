namespace DesignPatternsGOF.Factory.NetworkUtility;

internal class ARP : INetwork
{
    public void SendRequest(string ip, int timeSend)
    {
        Console.WriteLine($"ARP request send to ip: {ip}. Time send: {timeSend}");
    }
}
