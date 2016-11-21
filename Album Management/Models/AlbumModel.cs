using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Album_Management.Models
{
    public class Album
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string AlbumName { get; set;  }

        [Required]
        public string Artist { get; set;  }
    }

    public class AlbumDbContext : DbContext
    {
        public AlbumDbContext()
            : base("IPDatabaseConnection")

        {
        }

        public DbSet<Album> Albums { get; set; }

    }
}