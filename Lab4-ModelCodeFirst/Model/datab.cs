using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ModelCodeFirst.Model
{
    public class Model1 : DbContext
    {
        // Your context has been configured to use a 'Model1' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'ModelCodeFirst.Model1' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Model1' 
        // connection string in the application configuration file.
        public Model1()
            : base("name=Model1")
        {
        }
        public class Album
        {
            public int AlbumId { get; set; }
            public string AlbumName { get; set; }
        }


        public class Artist
        {
            public int ArtistId { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        public class AlbumsContext : DbContext
        {
            public DbSet<Album> Albums { get; set; }
            public DbSet<Artist> Artists { get; set; }
        }
    }
}
