using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Album_Management.Models
{
    public class Song
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int AlbumId { get; set; }

        [Required]
        public string SongName { get; set; }
    }

    public class SongDbContext : DbContext
    {
        public SongDbContext()
            : base("IPDatabaseConnection")

        {
        }

        public DbSet<Song> Songs { get; set; }

    }
}