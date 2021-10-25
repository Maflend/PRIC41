using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureSalesCompanyProject.Models
{
    public class User
    {
        [Key]public string Login { get; set; }
        [Required] public string Password { get; set; }
        public string Discriminator { get; set; }
    }
}
