﻿using SEDC.PizzaApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.PizzaApp.Domain.Models
{
    public class PizzaOrder
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } 
        public int PizzaId { get; set; } 
        public Pizza Pizza { get; set; } 
        public int OrderId { get; set; } 
        public Order Order { get; set; } 
        public PizzaSize PizzaSize { get; set; } 
        public double Price { get; set; } 
        public int NumberOfPizzas { get; set; } 
    }
}
