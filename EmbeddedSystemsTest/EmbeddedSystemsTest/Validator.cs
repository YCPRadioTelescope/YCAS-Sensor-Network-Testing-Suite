using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace EmbeddedSystemsTest
{
    public class Validator
    {
        public static bool serverIpExists(string ip, int port)
        {
            bool success = false;

            TcpListener s = new TcpListener(IPAddress.Parse(ip), port);
            try
            {
                s.Start();
                success = true;
                s.Stop();
            }
            catch { success = false; }

            return success;
        }

        public static bool ipValid(string ip)
        {
            IPAddress i;
            if (!IPAddress.TryParse(ip, out i)) return false;
            return true;
        }

        public static bool clientIpExists(string ip, int port)
        {
            bool success = false;
            TcpClient c = new TcpClient();
            try
            {
                c.Connect(ip, port);
                success = true;
            }
            catch { success = false; }

            c.Close();
            c.Dispose();

            return success;
        }

        public static bool isPort(string portStr)
        {
            if (!isNumeric(portStr)) return false;

            int portInt;
            if(!int.TryParse(portStr, out portInt)) return false;

            if (portInt > 0 && portInt < 65535) return true;
            else return false;
        }

        public static bool isNumeric(string s)
        {
            return s.All(char.IsNumber);
        }

        public static bool isBetween(int val, int low, int high)
        {
            if (val > high || val < low) return false;
            return true;
        }
    }
}
