using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public class productManagement
    {
        public List<Product> ListProduct = null;

        public productManagement()
        {
            ListProduct = new List<Product>();
        }

        public void addProduct()
        {
            Product produck = new Product();
            Console.WriteLine("Please Enter Product Id : ");
            produck.ProducId = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Please Enter Product Name : ");
            produck.Name = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Please Enter Product Price : ");
            produck.Price = Convert.ToInt32(Console.ReadLine());

            ListProduct.Add(produck);
        }
        public void displayProduct(List<Product> products)
        {
            Console.WriteLine("{0, -5} | {1, -15} | {2, -25} |  | ", "ProductId", "Name", "Price");
            if (products != null)
            {
                foreach (Product pr in products)
                {
                    Console.WriteLine("{0, -5} | {1, -15} | {2, -25} |  ", pr.ProducId, pr.Name, pr.Price);
                }
            }
            Console.WriteLine();
        }
        public bool deleteProduct(string id)
        {
            bool PDeleted = false;
            Product productId = FindProductId(id);
            if (productId != null)
            {
                PDeleted = ListProduct.Remove(productId);
            }
            return PDeleted;
        }
        public Product FindProductId(string productID)
        {
            Product findId = null;
            if(ListProduct != null)
            {
                foreach (Product productaidi in ListProduct)
                {
                    if (productaidi.ProducId==productID)
                    {
                        findId = productaidi;
                    }
                }
            }
            return findId;
        }
        public List<Product> GetProducts()
        {
            return ListProduct;
        }
    }
}
