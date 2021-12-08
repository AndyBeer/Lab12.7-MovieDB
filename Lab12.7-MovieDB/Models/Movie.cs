using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab12._7_MovieDB.Models
{
//    create table movies(
//ID int NOT NULL auto_increment primary key,
//Title nvarchar(30),
//Genre nvarchar(15),
//Year int,
//Runtime int
//);
    public class Movie
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [MaxLength(30, ErrorMessage ="Error: Title can be no longer than 30 characters.")]
        public string Title { get; set; }
        [Required]
        public string Genre { get; set; }
        [Range(1880, 2021)]
        public int Year { get; set; }
        
        public int Runtime { get; set; }

        public override string ToString()
        {
            return "ID: " + ID + " Title: " + Title + " Genre: " + Genre + " Year: " + Year + " Runtime: " + Runtime;
        }
    }

}
