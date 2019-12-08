using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Mime;

namespace MovieShopApp.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        [ForeignKey("Category")]
        public string Category { get; set; }
        public float Price { get; set; }
        
    }
}