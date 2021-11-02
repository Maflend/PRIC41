using FurnitureSalesCompanyProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureSalesCompanyProject
{
    public class AddStartingDate
    {
        public void Add()
        {
            FurnitureContext db = new FurnitureContext();
            Category Category1 = new Category() { Name = "Компьютерный стол" };
            Category Category2 = new Category() { Name = "Книжный шкаф" };
            Category Category3 = new Category() { Name = "Тумба" };
            db.AddRange(Category1,Category2,Category3);

            Furniture furniture1 = new Furniture() {Category = Category1, Model = "СК-1", Cost = 15000.20, Specifications ="Сделана из поликарбаната. Ширина: 1.5м, Высота: 0.6м"};
            Furniture furniture2 = new Furniture() { Category = Category1, Model = "СК-2", Cost = 12000, Specifications = "Сделана из дерева. Ширина: 5м, Высота: 2м" };
            Furniture furniture3 = new Furniture() { Category = Category2, Model = "Ш-1", Cost = 30000, Specifications = "Ширина: 1м, Высота: 3м" };
            Furniture furniture4 = new Furniture() { Category = Category2, Model = "Ш-2", Cost = 35000, Specifications = "Сделана из поликарбаната." };
            Furniture furniture5 = new Furniture() { Category = Category3, Model = "Т-0", Cost = 4000, Specifications = "Дверки: раздвижные. Ширина: 1м, Высота: 3м" };
            db.AddRange(furniture1, furniture2, furniture3, furniture4, furniture5);

            Sale sale1 = new Sale() {Furniture = furniture1, Quantity = 2 };
            Sale sale2 = new Sale() {Furniture = furniture2, Quantity = 1 };
            Sale sale3 = new Sale() {Furniture = furniture5, Quantity = 1 };
            db.AddRange(sale1,sale2,sale3);

            Customer customer1 = new Customer() {Login = "customer1", Password = "customer1", Code = Guid.NewGuid(), Name ="ООО СельхозКолхоз", Address= "ул. Юнатова, д.5", Phone ="+79551567896"};
            Customer customer2 = new Customer() { Login = "customer2", Password = "customer2", Code = Guid.NewGuid(), Name = "ООО СмолГу", Address = "ул. Дзержинского, д.12", Phone = "+79429981541" };
            db.AddRange(customer1, customer2);
            Stuff stuff1 = new Stuff() {Login = "Stuff", Password = "Stuff" };
            db.AddRange(stuff1);

            Contract contract1 = new Contract()
            { IsApproved = true, RegistrationDate = new DateTime(2021,8,13), DateOfExecution= new DateTime(2021, 9, 29), Sales = new List<Sale>() {sale1,sale2 }, Customer = customer1 };
            Contract contract2 = new Contract() 
            { IsApproved = true, RegistrationDate = new DateTime(2021, 9, 20), DateOfExecution = new DateTime(2021, 9, 28), Sales = new List<Sale>() { sale3 }, Customer = customer2 };
            db.AddRange(contract1,contract2);

            db.SaveChanges();
        }
       
        
    }
}
