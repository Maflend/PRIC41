using FurnitureSalesCompanyProject.Models;
using FurnitureSalesCompanyProject.StaticData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureSalesCompanyProject.Controllers
{
    public class ContractController
    {
        FurnitureContext db = new FurnitureContext();
        public bool Post(Contract contract, List<Sale> sales)
        {
            var user = ContextStatic.FurnitureContext.Users.FirstOrDefault(i => i.Login == CurrentUser.User.Login);
            if (user != null)
            {
                contract.Customer = (Customer)user;
                contract.Sales = sales;
                
                ContextStatic.FurnitureContext.Contracts.Add(contract);
                ContextStatic.FurnitureContext.SaveChanges();
                return true;
            }
            return false;
        }
        public List<Contract> GetAll()
        {
            var contracts = db.Contracts.Where(o => o.Customer.Login == CurrentUser.User.Login).Select(o => o).ToList();    
            return contracts;
        }
    }
}
