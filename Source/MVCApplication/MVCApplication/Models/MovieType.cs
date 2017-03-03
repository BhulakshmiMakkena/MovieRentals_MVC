using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCApplication.Models
{
    [Table("MovieType")]
    public class MovieType
    {
        public int MovieTypeID { get; set; }
        public string MovieTypeName { get; set; }
        public List<movie> movies { get; set; }
    }
}