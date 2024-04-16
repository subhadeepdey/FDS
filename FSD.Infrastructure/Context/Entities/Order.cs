using System.ComponentModel.DataAnnotations.Schema;
using FSD.Infrastructure.Context.Entities;

namespace FSD.Infrastructure.Context.Entities
{
    [Table("ORDER")]
    public class Order : BaseEntity
    {
        [Column("NAME")]
        public string Name { get; set; } = string.Empty;
        [Column("DESCRIPTION")]
        public string Description { get; set; } = string.Empty;
        [Column("PRICE")]
        public decimal Price { get; set; }
        [Column("STOCK")]
        public int Stock { get; set; }
    }
}

