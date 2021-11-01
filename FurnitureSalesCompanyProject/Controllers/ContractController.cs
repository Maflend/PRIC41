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
        public bool Post(Contract contract)
        {
            var user = ContextStatic.FurnitureContext.Users.FirstOrDefault(i => i.Login == CurrentUser.User.Login);
            var sale = SaleStatic.Sales.Select(l => l);
            if (user != null)
            {
                Contract con = new Contract();
                con.Sales = SaleStatic.Sales;
                con.Customer = (Customer)user;
                con.RegistrationDate = DateTime.Now;
                con.DateOfExecution = con.RegistrationDate.AddDays(7);
                ContextStatic.FurnitureContext.Contracts.Add(con);
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
