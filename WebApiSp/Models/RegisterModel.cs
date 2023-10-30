using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiSp.Models
{
    [Table("AspNetUsers")]
    public class RegisterModel
    {
        public string UserName { get; set; }
        public string PasswordHash { get; set; }

        public int AccessFailedCount { get; set; }

        public int LockoutEnabled { get; set; }
        public int TwoFactorEnabled { get; set; }

        public int PhoneNumberConfirmed { get; set; }

        public int EmailConfirmed { get; set; }


    }
}
