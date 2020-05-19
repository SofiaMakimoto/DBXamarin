using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppBD.Model
{
    public class Customer
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
