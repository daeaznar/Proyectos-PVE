namespace ImagesWindow.Data
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Event")]
    public partial class Event
    {
        public long EventId { get; set; }

        [Required]
        [StringLength(50)]
        public string Subject { get; set; }

        [Column(TypeName = "date")]
        public DateTime EventDate { get; set; }
    }
}
