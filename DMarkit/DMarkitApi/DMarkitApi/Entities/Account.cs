using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DMarkitApi.Entities
{
    public class Account
    {
        [Key]
        public Guid Id { get; set; }

        public Guid ApplicationUserId { get; set; }

        [Required]
        public string Nuben { get; set; }

        [Required]
        public string AvaliableBalance { get; set; }



    }
}
