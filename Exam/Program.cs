using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class Program
    {
        productManagement produckmana = new productManagement();
        static void Main(string[] args)
        {
            Program exam = new Program();
            exam.Menu();
        }
        public void Menu()
        {
            int choose;

            while (true)
            {
                Console.WriteLine("\n\t\t\t   Product Management Program.  \n");
                Console.WriteLine("\t\t ================== MAIN MENU ===================");
                Console.WriteLine("\t\t|          1. Add product  .                    |");
                Console.WriteLine("\t\t|          2. Display product.                  |");
                Console.WriteLine("\t\t|          3. Delete product by Id.             |");
                Console.WriteLine("\t\t|          0. Exit.                             |");
                Console.WriteLine("\t\t ================================================");
                try
                {
                    Console.Write("\n\t# Choose : ");
                    choose = Convert.ToInt32(Console.ReadLine());

                    switch (choose)
                    {
                        case 1:
                            Console.Clear();
                            produckmana.addProduct();
                            Console.Clear();
                            break;

                        case 2:
                            Console.Clear();
                            produckmana.displayProduct(produckmana.GetProducts());
                            Console.Clear();
                            break;

                        case 3:
                            Console.Clear();
                            string id;
                            Console.WriteLine("\n Enter Product Id ");
                            id = Console.ReadLine();
                            produckmana.deleteProduct(id);
                            Console.WriteLine("Deleted !!");
                            Console.Clear();
                            break;

                        case 0:
                            Console.WriteLine("\n\n\t\t See You Agian !! \n\n");
                            Environment.Exit(0);
                            break;

                        default:
                            Console.Clear();
                            Console.WriteLine("\n\n\t\t\tWronggg Input , Please Try Again\n\n");
                            break;

                    }
                }
                catch (Exception error)
                {
                    Console.Clear();
                    Console.WriteLine("\n\t\t\t Wronggg Input !!");
                    Console.WriteLine("\t\t\t=> " + error.Message);
                }



            }
        }
        
    }
}
