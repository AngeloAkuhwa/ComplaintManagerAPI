using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacilityComplaintManager.Identity.Entity
{
    public class AppUser:IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        //public Stack Stack { get; set; }
        //public Squad Squad { get; set; }
        //public ICollection<Complaint> Complains { get; set; }
        //public ICollection<Reply> Replies { get; set; }
    }
}
