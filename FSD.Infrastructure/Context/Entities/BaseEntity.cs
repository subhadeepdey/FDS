using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FSD.Infrastructure.Context.Entities
{
    public class BaseEntity
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
    }
}

