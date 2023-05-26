namespace DesignPatternsGOF.Facade;

internal class NetworkFacade
{
    private Packet packet;
    private Socket socket;
    private Transmission transmission;

    public NetworkFacade(string ip, string protocol)
    {
        packet = new Packet(ip);
        socket = new Socket(protocol);
        transmission = new Transmission(protocol);
    }

    public void BuildNetwordkLayer()
    {
        packet.PacketBuilt();
        socket.SocketBuilt();
    }

    public void SendPacketOverNetwork()
    {
        BuildNetwordkLayer();
        transmission.SendTransmission();
    }
}
