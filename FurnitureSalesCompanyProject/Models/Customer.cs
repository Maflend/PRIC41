using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureSalesCompanyProject.Models
{
    public class Customer : User
    {
        public Guid Code { get; set; } = Guid.NewGuid();
        [Required] public string Name { get; set; }
        [Required] public string Address { get; set; }
        [Required][Phone] public string Phone { get; set; }
        [Required] public List<Contract> Contracts { get; set; }
    }
}
