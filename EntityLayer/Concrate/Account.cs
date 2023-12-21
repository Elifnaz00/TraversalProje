using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    public class Account
    {
        public int AccountID { get; set; }
        public string Name { get; set; }
        public decimal Balance { get; set; }
    }
}
