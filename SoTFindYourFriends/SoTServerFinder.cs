using System;
using System.Linq;
using System.Net;
using System.Net.Sockets;

namespace SoTFindYourFriends
{
    public static class SoTServerFinder
    {

        public static string FindSoTServer(IPAddress ip, int port)
        {
            // Credits : SoTServerFinder creator (can't find you)
            using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Raw, ProtocolType.IP))
            {
                socket.Bind(new IPEndPoint(ip, 0));
                socket.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.AcceptConnection, optionValue: true);

                byte[] optionInValue = new byte[4] { 1, 0, 0, 0 };
                byte[] optionOutValue = new byte[4];

                socket.IOControl(IOControlCode.ReceiveAll, optionInValue, optionOutValue);

                byte[] array = new byte[1024];
                socket.ReceiveTimeout = 5000;
                try
                {
                    socket.Receive(array);
                }
                catch (Exception)
                {
                    return string.Empty;
                }
                if (array.Skip(9).First() != 17)
                {
                    return string.Empty;
                }

                string localIp = new IPAddress(BitConverter.ToUInt32(array, 16)).ToString();
                string localPort = ((ushort)IPAddress.NetworkToHostOrder(BitConverter.ToInt16(array, 22))).ToString();
                string remoteIp = new IPAddress(BitConverter.ToUInt32(array, 12)).ToString();
                string remotePort = ((ushort)IPAddress.NetworkToHostOrder(BitConverter.ToInt16(array, 20))).ToString();

                if (remotePort == port.ToString())
                {
                    return localIp + ":" + localPort;
                }
                if (localPort == port.ToString())
                {
                    return remoteIp + ":" + remotePort;
                }

                return string.Empty;
            }
        }

    }
}
