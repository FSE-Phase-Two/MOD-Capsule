using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MOD.DATA.Model
{
    public class Technology
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TechnologyId { get; set; }

        [Required]
        [Column(TypeName = "varchar(250)")]
        public string Name { get; set; }

        [Required]
        public string TechnologyContent { get; set; }

        [Required]
        public string Prerequisite { get; set; }
        [Required]
        public int Duration { get; set; }

        [Required]
        public double Fees { get; set; }
    }
}
