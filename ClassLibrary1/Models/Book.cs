using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainBookStore.Models
{
    internal class Book : Product

    {
        public string AuthorName { get; set; }
        public int PageCount { get; set; }

        public Book(int ıD, string name, double price, int count, int totalCome, int sell) : base(ıD, name, price, count, totalCome, sell)
        {

        }

        public override void Selll()
        {
            if (Count>0)
            {
                Count--;
                TotalCome += Price;
            }
            else
            {
                Console.WriteLine("Kitablar satildi"); 
            }
            
        }

        public override void ShowInfo()
        {
            throw new NotImplementedException();
        }
  
    }
}
