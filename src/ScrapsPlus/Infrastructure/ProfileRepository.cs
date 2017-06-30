using ScrapsPlus.Data;
using ScrapsPlus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScrapsPlus.Infrastructure
{
    public class ProfileRepository : GenericRepository<Profile>
    {
        public ProfileRepository(ApplicationDbContext db) : base(db) { }
    }
}
