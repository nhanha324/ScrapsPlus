using ScrapsPlus.Data;
using ScrapsPlus.Infrastructure;
using ScrapsPlus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScrapsPlus.Services
{
    public class ProfileService
    {
        private ProfileRepository db;
        public ProfileService(ProfileRepository profRepo)
        {
            db = profRepo;
        }

        public Profile AddProfile(Profile newProfile) {
            var profile = newProfile;
            profile.JoinDate = DateTime.Now;
            profile.Age = 26; 
                //int.Parse((DateTime.Now - profile.DateOfBirth).TotalDays.ToString());
            profile.MembershipLevelID = 4;
            profile.SubscriptionStatusID = 2;
            profile.Email = newProfile.Email;

            profile.Address = "123";
            profile.MembershipLevel = new MembershipLevel
            {
                Level = "Non-member"
            };
            profile.SubscriptionStatus = new SubscriptionStatus
            {
                Status = "Inactive"
            };
            db.Add(profile);
            db.SaveChanges();
            return profile;
        }

        public Profile GetProfile(string email)
        {
            var profile = (from p in db.List()
                           where email == p.Email
                           select p).FirstOrDefault();

            return profile;
        }
    }
}
