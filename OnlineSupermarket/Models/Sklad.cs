﻿using System.ComponentModel.DataAnnotations;

namespace OnlineSupermarket.Models
{
    public class Sklad
    {
        [Key]
        public int IdSkladu { get; set; }
        public int PocetPolicek { get; set; }
        public int Plocha { get; set; }
    }
}
