using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCApplication.Models
{
    [Table("MovieDetails")]
    public class movie
    {
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public string DirectorName { get; set; }
        public string HeroName { get; set; }
        public string HeroinName { get; set; }
        public int MovieTypeID { get; set; }
        public MovieType  MovieType { get; set; }

       // [ForeignKey("MovieType")]
       // public string MovieTypeName { get; set; }
         // [ForeignKey("MovieType")]
        //public string MovieTypeID { get; set; }
       // public List<movie> movies { get; set; }

    }
}