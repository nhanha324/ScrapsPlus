using ScrapsPlus.Data;
using ScrapsPlus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScrapsPlus.Services
{
    public class ProfileService
    {
        ApplicationDbContext db;
        public Profile AddProfile(Profile newProfile) {
            var profile = newProfile;
            profile.JoinDate = DateTime.Now;
            profile.Age = int.Parse((DateTime.Now - profile.DateOfBirth).TotalDays.ToString());
            profile.MembershipLevelID = 4;
            profile.SubscriptionStatusID = 2;
            db.Add(profile);
            db.SaveChanges();
            return profile;
        }
    }
}
