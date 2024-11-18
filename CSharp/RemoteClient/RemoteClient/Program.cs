using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using RemotingServices;

namespace RemoteClient
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpChannel c = new HttpChannel(8003);
            ChannelServices.RegisterChannel(c);

            //create a service class object (i.e. proxy fo rthe remote)
            RemoteServices rproxy = (RemoteServices)Activator.GetObject(typeof(RemoteServices),
                "http://localhost:87/OurFirstRemoteService");

            //invoke the methods
            Console.WriteLine("The Max number is " + rproxy.WriteMessage(15,35));
            Console.Read();
        }
    }
}
