using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureSalesCompanyProject.Models
{
    public class Furniture
    {
        [Key]public int Id { get; set; }
        [Required] public string Model { get; set; }
        [Required] public string Specifications { get; set; }
        [Required] public double  Cost { get; set; }
        [ForeignKey("Name")] [Required] public FurnitureName FurnitureName { get; set; }
        public List<Sale> Sales { get; set; }
    }
}
