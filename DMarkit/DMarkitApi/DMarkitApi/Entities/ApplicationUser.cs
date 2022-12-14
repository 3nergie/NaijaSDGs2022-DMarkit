using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DMarkitApi.Entities
{
    public class ApplicationUser : IdentityUser
    {
      
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }
        public string Gender { get; set; }

        public DateTimeOffset DateofBirth { get; set; }

        //public ICollection<Account> Accounts { get; set; }
        //    = new List<Account>();

        public Account Account { get; set; }
    }
}
