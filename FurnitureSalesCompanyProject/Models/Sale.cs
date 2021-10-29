using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureSalesCompanyProject.Models
{
    public class Sale
    {
        [Key] public int Id { get; set; }
        [Required] public Contract Contract { get; set; }
        [Required] public Furniture Furniture { get; set; }
        [Required] public int Quantity { get; set; }
    }
}
