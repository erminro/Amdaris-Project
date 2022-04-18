using System;
using System.Collections.Generic;

namespace InernshipApplication.Web.Domain
{
    public class Category
    {
        public Guid Id { get; set; }

        public ICollection<Product> Product;
        public Guid Productid { get; set; }
        public string Name { get; set; }
    }
}
