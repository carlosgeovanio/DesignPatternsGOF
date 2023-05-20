using DesignPatternsGOF.Factory.NetworkUtility;

namespace DesignPatternsGOF.Factory.NetworkFactory;

internal class NetworkFactory
{
    public INetwork GetNetworkInstante(NetworkType type)
    {
        INetwork? obj;
        switch (type)
        {
            case NetworkType.ARP:
                obj = new ARP();
                break;
            case NetworkType.DNS:
                obj = new DNS();
                break;
            case NetworkType.Ping:
                obj = new Ping();
                break;
            default:
                throw new ArgumentException("Type not found");
        }
        return obj;
    }
}
