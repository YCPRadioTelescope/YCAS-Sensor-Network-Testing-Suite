﻿using System;
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
            // TODO: find a way to validate if a server IP exists
            return true;
        }

        public static bool ipValid(string s)
        {
            IPAddress i;
            if (!IPAddress.TryParse(s, out i)) return false;
            return true;
        }

        public static bool clientIpExists(string ip, int port)
        {
            TcpClient c = new TcpClient();
            try
            {
                c.Connect(ip, port);
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
