namespace DesignPatternsGOF.Factory.NetworkUtility;

internal interface INetwork
{
    void SendRequest(string ip, int timeSend);
}
