using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScrapsPlus.API.NewFolder.ViewModels
{
    public class ProfileViewModel
    {
       
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public DateTime JoinDate { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string RecoveryEmail { get; set; }
        public string MembershipLevel { get; set; }
        public string SubscriptionStatus { get; set; }
    }
}
