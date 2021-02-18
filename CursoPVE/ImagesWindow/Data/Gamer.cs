using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ImagesWindow.Data
{
    [Table("Gamer")]
    public partial class Gamer
    {
        [Key]
        [StringLength(10)]
        public string GamerTag { get; set; }

        [Required]
        [StringLength(20)]
        public string GamingConsole { get; set; }
    }
}
