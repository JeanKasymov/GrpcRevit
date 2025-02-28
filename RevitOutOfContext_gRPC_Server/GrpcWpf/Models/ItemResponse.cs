using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrpcWpf.Models
{
    public class ItemResponse
    {
        public string Item { get; set; }
        public string Number { get; set; }
        public override string ToString()
        {
            return Item + " 1cNumber " + Number;
        }
    }
}