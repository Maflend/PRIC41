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
                    if (CurrentUser.User is Employee)
                        CurrentUser.isCustomer = false;
                    if (CurrentUser.User is Customer)
                        CurrentUser.isCustomer = true;
                    if (CurrentUser.User is Admin)
                        CurrentUser.isAdmin = true;
                }
                return true;
            }
            return false;
        }
        public User GetUserData(string login)
        {
            var user = db.Users.FirstOrDefault(u => u.Login == login);
            return user;
        }
        public List<Customer> GetAllCustomers()
        {
            var customers = db.Customers.ToList();
            return customers;
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
