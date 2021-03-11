namespace SegundoExamenParcial.Data
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("DanceChampionship")]
    public partial class DanceChampionship
    {
        [Key]
        public long RegisterId { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string City { get; set; }

        [Required]
        [StringLength(10)]
        public string Gender { get; set; }

        [Required]
        [StringLength(50)]
        public string Category { get; set; }

        [Required]
        [StringLength(50)]
        public string Dance { get; set; }

        public short Score { get; set; }
    }
}
