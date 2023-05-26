namespace DesignPatternsGOF.Facade;

internal class Socket
{
    public string Id { get; set; }
    public string Port { get; set; }
    public string Protocol { get; set; }

    public Socket(string protocol)
    {
        Protocol = protocol;
    }

    public void SocketBuilt()
    {
        Console.WriteLine("Socket built!");
    }
}
