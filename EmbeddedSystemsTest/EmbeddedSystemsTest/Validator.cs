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
        public static bool serverIpValid(string s)
        {
            IPAddress i;
            if(!IPAddress.TryParse(s, out i)) return false;
            try
            {
                TcpListener t = new TcpListener(i, 2000);
                t.Start();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public static bool clientIpValid(string s)
        {
            IPAddress i;
            if (!IPAddress.TryParse(s, out i)) return false;
            try
            {
                TcpClient c = new TcpClient(i.ToString(), 2000);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public static bool isPort(string s)
        {
            if (!isNumeric(s)) return false;

            int port;
            if(!int.TryParse(s, out port)) return false;

            if (port > 0 && port < 65535) return true;
            else return false;
        }

        public static bool isNumeric(string s)
        {
            return s.All(char.IsNumber);
        }
    }
}
