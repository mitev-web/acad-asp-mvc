using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace Movies.Models
{
   public class Movie
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Date is required")]
        [DisplayFormat(DataFormatString = "{0:d}")]    
        public DateTime ReleaseDate { get; set; }

        [Required(ErrorMessage = "Genre must be specified")]
        public string Genre { get; set; }

        [Required(ErrorMessage = "Price Required")]
        [Range(1, 100, ErrorMessage = "Price must be between $1 and $100")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal Price { get; set; }
    }

    /// <summary>
    /// DbContext wraps ObjectContext and exposes the most commonly used features of ObjectContext 
    /// by using simplified and more intuitive APIs.
    /// </summary>
    public class MovieDBContext : DbContext
    {
        /// <summary>
        /// DbContext is usually used with a derived type that contains DbSet(Of TEntity) properties 
        /// for the root entities of the model. These sets are automatically initialized when the instance 
        /// of the derived class is created. 
        /// </summary>
        public DbSet<Movie> Movies { get; set; }
    }
}