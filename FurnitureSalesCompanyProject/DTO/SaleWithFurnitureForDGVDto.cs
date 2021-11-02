using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureSalesCompanyProject.DTO
{
    public class SaleWithFurnitureForDGVDto
    {
        public string Name { get; }
        public string Model { get; }
        public string Specifications { get; }
        public double Cost { get; }
        public int Quantity { get; }

        public SaleWithFurnitureForDGVDto(string name, string model, string specifications, double cost, int quantity)
        {
            Name = name;
            Model = model;
            Specifications = specifications;
            Cost = cost;
            Quantity = quantity;
        }

        public override bool Equals(object obj)
        {
            return obj is SaleWithFurnitureForDGVDto other &&
                   Name == other.Name &&
                   Model == other.Model &&
                   Specifications == other.Specifications &&
                   Cost == other.Cost &&
                   Quantity == other.Quantity;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Model, Specifications, Cost, Quantity);
        }
    }
}
