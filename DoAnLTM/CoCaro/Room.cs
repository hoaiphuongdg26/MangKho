using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoCaro
{
    public class Room
    {
        public string Id { get; set; }
        public bool IsOwner { get; set; }

        public Room(string id, bool isOwner)
        {
            Id = id;
            IsOwner = isOwner;
        }
    }
}
