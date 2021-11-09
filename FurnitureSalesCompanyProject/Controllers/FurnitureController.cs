using FurnitureSalesCompanyProject.DTO;
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

        public Furniture GetById(int id)
        {
            var furniture = db.Furnitures.FirstOrDefault(f => f.Id == id);
            return furniture;
        }
        public List<FurnitureForDGVDto> GetAllFurnitureForDGVDto()
        {
            var furnitures = db.Categories
               .SelectMany(f => f.Furnituries, (category, fur) => new { category, fur })
               .Select(f => new FurnitureForDGVDto(f.fur.Id, f.category.Name, f.fur.Model, f.fur.Specifications, f.fur.Cost))
               .ToList();
            return furnitures;
        }

        public bool AddFirniture(Furniture furniture)
        {
            db = new FurnitureContext();
            var category = db.Categories.FirstOrDefault(c => c.Name == furniture.Category.Name);           
            furniture.Category = category;
            db.Furnitures.Add(furniture);
            db.SaveChanges();
            return true;
        }
        public bool Update(Furniture newFurniture)
        {
            db = new FurnitureContext();
            var furniture = db.Furnitures.FirstOrDefault(f => f.Id == newFurniture.Id);
            if(furniture != null)
            {
                furniture.Model = newFurniture.Model;
                furniture.Sales = newFurniture.Sales;
                furniture.Specifications = newFurniture.Specifications;
                furniture.Cost = newFurniture.Cost;
                db.SaveChanges();
                return true;
            }
            return false;
        }
        public bool Delete(int id)
        {
            db = new FurnitureContext();
            var furniture = db.Furnitures.FirstOrDefault(f => f.Id == id);
            if(furniture !=null)
            {
                db.Remove(furniture);
                db.SaveChanges();
                return true;
            }
            return false;
        }













        public List<Category> GetCategories()
        {
            db = new FurnitureContext();
            var cat = db.Categories.Distinct().ToList();
            return cat;
        }
        public bool AddCategory(Category category)
        {
            db = new FurnitureContext();
            if (!db.Categories.Any(f => f.Name == category.Name))
            {
                db.Categories.Add(category);
                db.SaveChanges();
                return true;
            }
            return false;
        }
        public Category GetCategoryByName(string name)
        {
            db = new FurnitureContext();
            var category = db.Categories.FirstOrDefault(f => f.Name == name);
            return category;
        }

    }
}
