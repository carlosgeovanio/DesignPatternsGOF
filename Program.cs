#region Singleton
//using DesignPatternsGOF.Singleton;

//Singleton object1 = Singleton.Instance();
//Singleton object2 = Singleton.Instance();

//if (object1 == object2)
//{
//    Console.WriteLine("These objects are the same");
//}
#endregion

#region Factory
//using DesignPatternsGOF.Factory.NetworkFactory;
//using DesignPatternsGOF.Factory.NetworkUtility;

//var factory = new NetworkFactory();
//var arp = factory.GetNetworkInstante(NetworkType.ARP);
//var dns = factory.GetNetworkInstante(NetworkType.DNS);
//var ping = factory.GetNetworkInstante(NetworkType.Ping);

//arp.SendRequest("123.123.123.123", 1);
//dns.SendRequest("456.456.456.456", 2);
//ping.SendRequest("789.789.789.789", 3);
#endregion

#region Facade
using DesignPatternsGOF.Facade;

var networkFacade = new NetworkFacade("8.8.8.8", "UDP");
networkFacade.SendPacketOverNetwork();
#endregion