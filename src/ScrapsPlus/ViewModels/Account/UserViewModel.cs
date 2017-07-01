using ScrapsPlus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ScrapsPlus.ViewModels.Account
{
    public class UserViewModel
    {
        public string UserName { get; set; }

        public Dictionary<string,string> Claims { get; set; }
    }
}
