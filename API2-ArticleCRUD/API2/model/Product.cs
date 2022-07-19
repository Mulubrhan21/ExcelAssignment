using System;
using System.Collections.Generic;
using System.Text.Json;

namespace API2.model
{
    public class Product
    {
        public int Id { get; set; } 
        public float Price { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return JsonSerializer.Serialize<Product>(this);
        }
    }
}
