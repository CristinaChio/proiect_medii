using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace proiect_medii.Models
{
    public class PizzaOrder
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
    }
}
