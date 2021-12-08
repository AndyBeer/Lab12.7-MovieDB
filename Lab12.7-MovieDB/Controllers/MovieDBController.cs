using Lab12._7_MovieDB.Models;
using Microsoft.AspNetCore.Mvc;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;

namespace Lab12._7_MovieDB.Controllers
{
    public class MovieDBController : Controller
    {
        public IActionResult List()
        {
            List<Movie> movies = new List<Movie>();
            using (var connect = new MySqlConnection(Secret.Connection))
            {
                string sql = "select * from movies";
                connect.Open();
                movies = connect.Query<Movie>(sql).ToList();
                connect.Close();

                return View(movies);
            }   
        }
    }
}
