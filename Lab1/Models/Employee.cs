using System.ComponentModel.DataAnnotations;

namespace Lab1.Models
{
    public class Employee
    {

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Employee name is required.")]
        [StringLength(100, ErrorMessage = "Employee name cannot exceed 100 characters.")]
        [Display(Name = "Employee Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Phone number is required.")]
        [Phone(ErrorMessage = "Please enter a valid phone number.")]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

    

        [DataType(DataType.Date)]
        [Display(Name = "Birth Date")]
        public DateTime? Birthdate { get; set; }


        public Employer Employer {
            get; set; }  
    }
}

