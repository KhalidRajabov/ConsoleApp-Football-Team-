using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DataContext
    {
        public static List<Players> Players { get; set; }
        public static List<Clubs> Clubs { get; set; }
         static DataContext()
        {
            Players = new List<Players>();
            Clubs = new List<Clubs>();
        }
    }
}
