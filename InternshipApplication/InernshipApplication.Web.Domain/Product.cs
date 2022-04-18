using System;
using System.Collections.Generic;

namespace InernshipApplication.Web.Domain
{
    public class Product
    {
        public Guid Id { get; set; } 
        public string Name { get; set; }
        public string CompanyName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImagePath { get; set; }
        public ICollection<Review> Reviews { get; set; }
        public ICollection<Category> Categories { get; set; }
    }
}