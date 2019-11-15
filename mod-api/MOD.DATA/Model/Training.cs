using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MOD.DATA.Model
{
    public class Training
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TrainingId { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Status { get; set; }
        [Required]
        public int Progress { get; set; }
        [Required]
        public int Rating { get; set; }
        [Required]
        public double AmountReceived { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        [Required]
        public TimeSpan StartTime { get; set; }

        [Required]
        public TimeSpan EndTime { get; set; }
        public int UserId { get; set; }
        public int MentorId { get; set; }
        public int TechnologyId { get; set; }
        public User User { get; set; }
        public Technology Technology { get; set; }
        public Mentor Mentor { get; set; }

    }
}
