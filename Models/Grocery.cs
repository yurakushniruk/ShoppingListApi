using System;
namespace ShoppingListApi.Models
{
    public class Grocery
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public Boolean Purchased { get; set; }

        public Grocery()
        {

        }
    }
}

