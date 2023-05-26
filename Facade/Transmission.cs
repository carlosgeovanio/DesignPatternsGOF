namespace DesignPatternsGOF.Facade;

internal class Transmission
{
    public int Id { get; set; }
    public string Name { get; set; }

    public Transmission(string protocolName)
    {
        Name = protocolName;
    }

    public void SendTransmission()
    {
        Console.WriteLine("Send Transmission");
    }
}
