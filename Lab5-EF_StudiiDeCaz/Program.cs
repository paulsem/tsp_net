using EF_StudiiDeCaz.Model;
using System.Linq;
using System;

namespace EF_StudiiDeCaz
{
    class Program
    {
        static void Main(string[] args)
        {
            //Scenariul1();
            Scenariul_2_Insert();
            Scenariul_2_Show();
        }
        
        public static void Scenariul1()
        {
            using (var db = new ModelSelfReferences())
            {
                var nume = new Model.SelfReference { Name = "Mihai" };
                db.SelfReferences.Add(nume);
                db.SaveChanges();

                var query = from b in db.SelfReferences
                            orderby b.Name
                            select b;
                Console.WriteLine("All data in database");

                foreach (var item in query)
                {
                    Console.WriteLine(item.Name);
                }
                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
            }
        }

        public static void Scenariul_2_Insert()
        {
            using (var db = new ProductContext())
            {
                var product = new Product
                {
                    SKU = 144,
                    Description = "Expandable Hydration Pack",
                    Price = 19.97M,
                    ImageUrl = "/pack14.jpg"
                };

                db.Products.Add(product);
                db.SaveChanges();
            }
        }

        public static void Scenariul_2_Show()
        {
            using (var context = new ProductContext())
            {
                foreach( var p in context.Products)
                {
                    Console.WriteLine("{0} {1} {2} {3}", p.SKU, p.Description, p.Price.ToString("C"), p.ImageUrl);
                }
                Console.ReadKey();
            }
        }

    }
}
