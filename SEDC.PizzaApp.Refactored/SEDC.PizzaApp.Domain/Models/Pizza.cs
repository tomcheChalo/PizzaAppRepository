using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.PizzaApp.Domain.Models
{
    public class Pizza
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }   
        public string Name { get; set; }   
        public bool IsOnPromotion { get; set; }
        //PizzaOrder is on the M side in the relation
        public List<PizzaOrder> PizzaOrders { get; set; }
    }
}
