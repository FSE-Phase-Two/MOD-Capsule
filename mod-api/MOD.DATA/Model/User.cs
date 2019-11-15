using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MOD.DATA.Model
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }

        [Required]
        [Column(TypeName = "varchar(250)")]
        public string Password { get; set; }

        [Required]
        [Column(TypeName = "varchar(250)")]
        public string EmailId { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string FirstName { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string LastName { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string ContactNumber { get; set; }

        [Required]
        public DateTime RegDatetime { get; set; }
        [Required]
        public bool IsActive { get; set; }

        public ICollection<Training> Trainings { get; set; }
    }
}
