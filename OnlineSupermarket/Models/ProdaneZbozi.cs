﻿using System.ComponentModel.DataAnnotations;

namespace OnlineSupermarket.Models
{
    public class ProdaneZbozi
    {
        [Key]
        public int Pocet { get; set; }
        public decimal ProdejniCena { get; set; }
        public int ZboziIdZbozi { get; set; }
        public int ProdejIdProdeje { get; set; }
        public int ProdejZboziIdZbozi { get; set; }
    }
}
