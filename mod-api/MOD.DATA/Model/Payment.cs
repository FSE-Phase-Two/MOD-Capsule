using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
namespace MOD.DATA.Model
{
    public class Payment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PaymentId { get; set; }
        [Required]
        public double Amount { get; set; }
        [Required]
        public DateTime TransactionDate { get; set; }
        [Required]
        [Column(TypeName = "varchar(250)")]
        public string TransactionType { get; set; }
        [Required]
        [Column(TypeName = "varchar(1000)")]
        public string Remark { get; set; }
        public int MentorId { get; set; }
        public Mentor Mentor { get; set; }
    }
}
