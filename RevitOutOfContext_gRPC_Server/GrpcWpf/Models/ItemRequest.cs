using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrpcWpf.Models
{
    public class ItemRequest(string item)
    {
        public string Item => item;
    }
}
