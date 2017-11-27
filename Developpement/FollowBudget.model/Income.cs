using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FollowBudget.model
{
    [Table("Income")]
    public class Income
    {
        [Key]
        [Column("ID")]
        public int ID { get; set; }

        [Required]
        [Column("Amount")]
        public double Amount { get; set; }

        [Column("Date")]
        public DateTime? Date { get; set; }

        [Required]
        [Column("CreationDate")]
        public DateTime? CreationDate { get; set; }

        [Column("Description")]
        public string Description { get; set; }

        [Required]
        public Account Account { get; set; }
    }
}
