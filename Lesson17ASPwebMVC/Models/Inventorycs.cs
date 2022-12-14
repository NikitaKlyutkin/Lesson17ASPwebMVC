using Lesson17ASPwebMVC.Models.Domain;
using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;
using System.Text;
using System.Text.Json;

namespace Lesson17ASPwebMVC.Models
{
    public class Inventorycs
    {
        public List<Product> products = new List<Product>();

        public Inventorycs(string jsonFile)
        {
            string jsonString = File.ReadAllText(jsonFile);
            products = JsonSerializer.Deserialize<List<Product>>(jsonString);

        }

    }
}
