using FurnitureSalesCompanyProject.DTO;
using FurnitureSalesCompanyProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureSalesCompanyProject.Controllers
{
    public class SaleController
    {
        FurnitureContext db;
        public SaleController()
        {
            
        }

        public List<SaleWithFurnitureForDGVDto> GetSalesByContractNumber(int number)
        {
            db = new FurnitureContext();
            var SalesDto = db.Sales.Where(s => s.Contract.Number == number).Select(s => new SaleWithFurnitureForDGVDto(s.Furniture.Category.Name, s.Furniture.Model, s.Furniture.Specifications, s.Furniture.Cost, s.Quantity)).ToList();
            return SalesDto;

        }
    }
}
