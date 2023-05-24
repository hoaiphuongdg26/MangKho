using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoCaro
{
    internal class SocketManager
    {
        private List<string> usedIPs;

        public SocketManager()
        {
            usedIPs = new List<string>();
        }

        public string GetUniqueIPAddress()
        {
            // Logic để tạo địa chỉ IP mới không trùng với các phòng đã có
            string ipAddress = GenerateIPAddress();
            while (usedIPs.Contains(ipAddress))
            {
                ipAddress = GenerateIPAddress();
            }

            usedIPs.Add(ipAddress);
            return ipAddress;
        }

        private string GenerateIPAddress()
        {
            // Logic để tạo địa chỉ IP mới
            // ...
            return "";
        }
    }
}
