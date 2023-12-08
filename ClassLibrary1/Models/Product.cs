using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DomainBookStore.Models
{
    public abstract class Product
    {
        private static int BookIdCounter = 1;
        public int ID { get; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }
        public int TotalCome { get; set; }
        public int Sell { get; set; }

        public Product (int ıD, string name, int price, int count, int totalCome, int sell)
        {
            ID = BookIdCounter++;
            Name = name;
            Price = price;
            Count = count;
            TotalCome = totalCome;
            Sell = sell;
        }
        public abstract void Selll();
        public abstract void ShowInfo();
    }
    
}
