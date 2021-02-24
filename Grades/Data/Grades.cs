namespace Grades.Data
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Grades")]
    public partial class Grade
    {
        [Key]
        public long GradeID { get; set; }

        [Required]
        [StringLength(255)]
        public string StudentName { get; set; }

        public float FirstGrade { get; set; }

        public float SecondGrade { get; set; }

        public float ThirdGrade { get; set; }

        public float Exercises { get; set; }

        public float Project { get; set; }

        public float Exam { get; set; }

        public float TotalGrade { get; set; }
    }
}
