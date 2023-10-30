using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiSp.Models
{
    [Table("AspNetUsers")]
    public class LoginModel
    {
        [Required(ErrorMessage ="Username is Required")]
        public string UserName { get; set; }
        [Required(ErrorMessage ="Password is Required")]
        public string PasswordHash { get; set; }
    }
}
