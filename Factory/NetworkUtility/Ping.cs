namespace DesignPatternsGOF.Factory.NetworkUtility;

internal class Ping : INetwork
{
    public void SendRequest(string ip, int timeSend)
    {
        Console.WriteLine($"Ping request send to ip: {ip}. Time send: {timeSend}");
    }
}

