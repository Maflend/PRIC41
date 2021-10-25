using FurnitureSalesCompanyProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureSalesCompanyProject.Controllers
{
    public class FurnitureController
    {
        FurnitureContext db;
        public FurnitureController()
        {
            db = new FurnitureContext();
        }
        //public List<Furniture> GetFurnitures()
        //{
        //    //var furnitures = db.FurnitureNames
        //    //    .SelectMany(f => f.Furnituries, (furname, fur) => new { furname, fur })
        //    //    .Select(f => new { Id = f.fur.Id, Name = f.furname.Name, Model = f.fur.Model, Specifications = f.fur.Specifications, Cost = f.fur.Cost })
        //    //    .ToList();
        //    var fur = db.FurnitureNames
        //    return furnitures;
        //}
    }


    public class Product
    {
        public int Id;
        public List<Order> Orders;
    }
    public class Order
    {
        public int Id;
        public Product Product;
    }
    public class Main
    {
        public void Add()
        {
            List<Order> orders = new List<Order>() {
                new Order() {Id = 1, Product = new Product() {Id = 4 }},
                new Order() {Id = 2, Product = new Product() {Id = 3 }}
            };

            Order o = orders.Where(o=>o.Id == 1).First();
            int i = o.Product.Id;
        }
    }

}
