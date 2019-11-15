using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
namespace MOD.DATA.Model
{
    public class MentorTechnology
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MentorTechnologyId { get; set; }
        [Required]
        public int Experience { get; set; }
        [Required]
        public int SelfRating { get; set; }
        public int MentorId { get; set; }
        public int TechnologyId { get; set; }
        public Technology Technology { get; set; }
        public Mentor Mentor { get; set; }
    }
}
