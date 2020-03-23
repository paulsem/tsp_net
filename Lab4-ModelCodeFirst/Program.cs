using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ModelCodeFirst.Model.Model1;

namespace ModelCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new AlbumsContext())
            {
                var albums = new Album { AlbumName = "Album nou" };
                db.Albums.Add(albums);
                db.SaveChanges();

                var query = from b in db.Albums
                            orderby b.AlbumName
                            select b;
                Console.WriteLine("All albums in database");
                foreach(var item in query)
                {
                    Console.WriteLine(item.AlbumName);
                }
                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
            }
        }
    }

   
}
