using System;
using Microsoft.AspNetCore.Mvc;

namespace test_api.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        //public DateTime Timestamp {get;set;}
    }
}