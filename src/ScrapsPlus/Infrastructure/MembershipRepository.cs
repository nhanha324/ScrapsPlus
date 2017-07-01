using ScrapsPlus.Data;
using ScrapsPlus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScrapsPlus.Infrastructure
{
    public class MembershipRepository : GenericRepository<MembershipLevel>
    {
        public MembershipRepository(ApplicationDbContext db) : base(db) { }

        public MembershipLevel GetMembershipLevel(int id)
        {
            return (from l in _db.MembershipLevels
                    where id == l.ID
                    select new MembershipLevel
                    {
                        ID = l.ID,
                        Level = l.Level
                    }).FirstOrDefault();
        }
    }
}
