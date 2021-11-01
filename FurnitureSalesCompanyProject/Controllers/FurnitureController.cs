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
        public List<FurnitureForDGVDto> GetAllFurnitureForDGVDto()
        {
            var furnitures = db.FurnitureNames
               .SelectMany(f => f.Furnituries, (furname, fur) => new { furname, fur })
               .Select(f => new FurnitureForDGVDto(f.fur.Id, f.furname.Name, f.fur.Model, f.fur.Specifications, f.fur.Cost))
               .ToList();
            return furnitures;
        }
        public List<FurnitureName> GetCategories()
        {
            db = new FurnitureContext();
            var cat = db.FurnitureNames.Distinct().ToList();
            return cat;
        }
    }
}
