
using System ;

using System.Collections ;

class WebServer
{
    private Hashtable serverMap ;

    public WebServer()
    {
        serverMap = new Hashtable();

        serverMap.Add("192.168.1.1", "server1");
        serverMap.Add("192.168.1.2", "server2");
        serverMap.Add("192.168.1.3", "server3");

    }
    public string Routerequest(string ipAddress)
    {
        if(!serverMap.ContainsKey(ipAddress))
        {
            return "Error! Ip Address not found " ;
        }

        string serverName = (string)serverMap[ipAddress];
        return $"Routing to {serverName}";
       
    }



}

class hashTable
{
    static void Main(string[] args)
    {
        
        WebServer webserver = new WebServer();

        string webRequest1 = webserver.Routerequest("192.168.1.0");
        string webRequest2 = webserver.Routerequest("192.168.1.1");
        Console.WriteLine(webRequest1);
        Console.WriteLine(webRequest2);

    }

}