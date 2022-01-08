using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace proiect_medii.Models
{
    public class ListProduct
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [ForeignKey(typeof(PizzaOrder))]
        public int PizzaOrderID { get; set; }
        public int ProductID { get; set; }
    }
}
