using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GwebberAPI.Models
{
    public class UsersList
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime DateofBirth { get; set; }
        public int Age { get; set; }
    }
}