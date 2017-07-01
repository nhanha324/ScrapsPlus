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
        private ProfileRepository profiles;
        private MembershipRepository memLevels;
        private SubscriptionStausRepository subStatus;
        public ProfileService(ProfileRepository profRepo, MembershipRepository memRepo, SubscriptionStausRepository subRepo)
        {
            profiles = profRepo;
            memLevels = memRepo;
            subStatus = subRepo;
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
            profiles.Add(profile);
            profiles.SaveChanges();
            return profile;
        }

        public Profile GetProfile(string email)
        {
            var profile = (from p in profiles.List()
                           where email == p.Email
                           select new Profile
                           {
                               FirstName = p.FirstName,
                               LastName = p.LastName,
                               MembershipLevel = memLevels.GetMembershipLevel(p.MembershipLevelID),
                               DateOfBirth = p.DateOfBirth,
                               MembershipLevelID = p.MembershipLevelID,
                               Address = p.Address,
                               Age = p.Age,
                               Email = p.Email,
                               ID = p.ID,
                               JoinDate = p.JoinDate,
                               RecoveryEmail = p.RecoveryEmail,
                               SubscriptionStatusID = p.SubscriptionStatusID,
                               SubscriptionStatus = subStatus.GetSubscriptionStatus(p.SubscriptionStatusID)
                           }).FirstOrDefault();
            return profile;
        }
    }
}
