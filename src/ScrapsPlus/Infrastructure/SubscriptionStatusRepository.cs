using ScrapsPlus.Data;
using ScrapsPlus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScrapsPlus.Infrastructure
{
    public class SubscriptionStausRepository : GenericRepository<SubscriptionStatus>
    {
        public SubscriptionStausRepository(ApplicationDbContext db) : base(db) { }

        public SubscriptionStatus GetSubscriptionStatus(int id)
        {
            return (from s in _db.SubscriptionStatus
                    where id == s.ID
                    select new SubscriptionStatus
                    {
                        ID = s.ID,
                        Status = s.Status
                    }).FirstOrDefault();
        }
    }
}
