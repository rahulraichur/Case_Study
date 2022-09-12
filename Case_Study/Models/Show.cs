using System.ComponentModel.DataAnnotations;

namespace Case_Study.Models
{
    public class Show
    {
        
            [Key]
            public int ShowId { get; set; }

            [Required]
            [StringLength(100)]
            public string ShowName { get; set; }

            [Required]
            [StringLength(100)]
            public string Genre { get; set; }

            [Required]
            public string Description { get; set; }

            [Required]
            [StringLength(100)]
            public string Language { get; set; }

            [Required]
            public DateTime ReleaseDate { get; set; }

            public int Duration { get; set; }
            public string Cast { get; set; }

           
        }
    }

