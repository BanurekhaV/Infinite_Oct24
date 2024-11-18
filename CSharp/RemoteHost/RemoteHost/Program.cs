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


namespace RemoteHost
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a channel

            HttpChannel hc = new HttpChannel(87);

            //register the created channel
            ChannelServices.RegisterChannel(hc);

            //configuration info. about remote life services
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServices), "OurFirstRemoteService",
                WellKnownObjectMode.Singleton);
            Console.WriteLine("Server Services Startedd at Port No . 87 ......");
            Console.WriteLine("Press any key to stop the Server...");
            Console.Read();
        }
    }
}
