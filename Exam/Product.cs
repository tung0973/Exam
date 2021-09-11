using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public class Product
    {
        public string ProducId { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public Product()
        {

        }
        public Product(string productId,string name,double price)
        {
            this.ProducId = productId;
            this.Name = name;
            this.Price = price;
        }

    }
}
