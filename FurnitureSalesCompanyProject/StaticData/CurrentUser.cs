using FurnitureSalesCompanyProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureSalesCompanyProject.StaticData
{
    public static class CurrentUser
    {
        public static User User { get; set; }
        public static bool isCustomer { get; set; }
    }
    
}
