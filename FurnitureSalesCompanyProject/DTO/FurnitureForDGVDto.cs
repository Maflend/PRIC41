using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureSalesCompanyProject.DTO
{
    public class FurnitureForDGVDto
    {
        public int Id { get; }
        public string Name { get; }
        public string Model { get; }
        public string Specifications { get; }
        public double Cost { get; }

        public FurnitureForDGVDto(int id, string name, string model, string specifications, double cost)
        {
            Id = id;
            Name = name;
            Model = model;
            Specifications = specifications;
            Cost = cost;
        }

        public override bool Equals(object obj)
        {
            return obj is FurnitureForDGVDto other &&
                   Id == other.Id &&
                   Name == other.Name &&
                   Model == other.Model &&
                   Specifications == other.Specifications &&
                   Cost == other.Cost;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, Model, Specifications, Cost);
        }
    }
}
