using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FollowBudget.model
{
    [Table("Account")]
    public class Account
    {
        [Key]
        [Column("ID")]
        public int ID { get; set; }

        [Required]
        [Column("Name")]
        public string Name { get; set; }

        public ICollection<Income> Incomes { get; set; }
    }
}
