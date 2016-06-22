
using Microsoft.Owin.Hosting;
using System;
using System.Net;
using System.Net.Sockets;

namespace SelfHosting
{
    class Program
    {
        static void Main(string[] args)
        {
            var ip = GetLocalIPAddress();
            var port = 50000;
                        
            using (WebApp.Start<Startup>($"http://{ip}:{port}"))
            {
                Console.WriteLine($"Web Server is running on {ip}:{ port}.");
                Console.WriteLine("Press any key to quit.");
                Console.ReadLine();
            }

        }

        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("Local IP Address Not Found!");
        }
    }
}
