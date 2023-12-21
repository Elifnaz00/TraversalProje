using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    public class AppUser:IdentityUser<int>
    {
        public string? İmageUrl { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Gender { get; set; }

        public List<Reservation> Reservations { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
