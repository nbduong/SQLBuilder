﻿using SQLBuilder.Attributes;

namespace SQLBuilder
{
    [Table("Base_Country")]
    public class Country
    {
        [Column("Country_Id")]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
