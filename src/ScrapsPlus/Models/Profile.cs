using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ScrapsPlus.Models
{
    public class Profile
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public DateTime JoinDate { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string RecoveryEmail { get; set; }
        public int MembershipLevelID { get; set; }
        [ForeignKey("MembershipLevelID")]
        public MembershipLevel MembershipLevel { get; set; }

        public int SubscriptionStatusID { get; set; }
        [ForeignKey("SubscriptionStatusID")]
        public SubscriptionStatus SubscriptionStatus { get; set; }
    }
}
