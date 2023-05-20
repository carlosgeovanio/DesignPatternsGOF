namespace DesignPatternsGOF.Factory.NetworkUtility;

internal class DNS : INetwork
{
    public void SendRequest(string ip, int timeSend)
    {
        Console.WriteLine($"DNS request send to ip: {ip}. Time send: {timeSend}");
    }
}
