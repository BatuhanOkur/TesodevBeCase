using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Order
    {
        [Key]
        public Guid Id { get; set; }
        public int CustomerId { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public int Status { get; set; }
        public Product Product { get; set; }
        public Address Address { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
