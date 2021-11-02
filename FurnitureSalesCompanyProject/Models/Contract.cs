using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureSalesCompanyProject.Models
{
    public class Contract
    {
        [Key]public int Number { get; set; }
        public bool IsApproved { get; set; } = false;
        [Required] public DateTime RegistrationDate { get; set; }
        public DateTime DateOfExecution { get; set; }
        [Required] public Customer Customer { get; set; }
        [Required]public List<Sale> Sales { get; set; }

    }
}
