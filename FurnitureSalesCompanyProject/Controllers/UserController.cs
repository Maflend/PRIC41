using FurnitureSalesCompanyProject.Models;
using FurnitureSalesCompanyProject.StaticData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureSalesCompanyProject.Controllers
{
    public class UserController
    {
        FurnitureContext db = new FurnitureContext();
        public bool LogIn (User user)
        {
            
            if (db.Users.Any(u=>u.Login == user.Login && u.Password == user.Password))
            {
                var currentUser = GetUserData(user.Login);
                if(currentUser !=null)
                {
                    CurrentUser.User = currentUser;
                    if (CurrentUser.User is Stuff)
                        CurrentUser.isCustomer = false;
                    if (CurrentUser.User is Customer)
                        CurrentUser.isCustomer = true;
                }
                return true;
            }
            return false;
        }
        public User GetUserData(string login)
        {
            Customer customer = db.Customers.FirstOrDefault(u => u.Login == login);
            Stuff stuff = db.Stuffs.FirstOrDefault(u => u.Login == login);
            if (customer != null)
                return customer;
            if (stuff != null)
                return stuff;
            return new User();
        }
        public bool SignIn(Customer customer)
        {
            if (!db.Users.Any(u=>u.Login == customer.Login))
            {
                db.Users.Add(customer);
                db.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
