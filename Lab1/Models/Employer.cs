using System.ComponentModel.DataAnnotations;

namespace Lab1.Models
{
    public class Employer
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Employer name is required.")]
        [StringLength(100, ErrorMessage = "Employer name cannot exceed 100 characters.")]
        [Display(Name = "Employer Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Phone number is required.")]
        [Phone(ErrorMessage = "Please enter a valid phone number.")]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Website is required.")]
        [Url(ErrorMessage = "Please enter a valid URL.")]
        [Display(Name = "Website")]
        public string Website { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Incorporated Date")]
        public DateTime? IncorporatedDate { get; set; }
    }
}
