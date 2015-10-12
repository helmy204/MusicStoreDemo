using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MusicStore.Web.Models
{
    public class MusicStoreEntities:DbContext
    {
        public DbSet<Album> Albums { get; set; }
        public DbSet<Genre> Genres { get; set; }

        public System.Data.Entity.DbSet<MusicStore.Web.Models.Artist> Artists { get; set; }
    }
}