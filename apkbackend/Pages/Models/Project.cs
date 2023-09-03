using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace apkbackend.Pages.Models
{
    public class Project
    {


        public int Id { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string? Nazwa { get; set; }
        [Required]
        [Display(Name = "Data zgłoszenia")]
        [DataType(DataType.Date)]
       
        public DateTime Data_zgloszenia { get; set; }
        [Required]
        [Display(Name = "Status")]
        public string status { get; set; }
        public string Opiekun { get; set; }

    }
}
