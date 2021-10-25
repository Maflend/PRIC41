﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureSalesCompanyProject.Models
{
    public class FurnitureName
    {
        [Key]public string Name { get; set; }
        public List<Furniture> Furnituries { get; set; }
    }
}