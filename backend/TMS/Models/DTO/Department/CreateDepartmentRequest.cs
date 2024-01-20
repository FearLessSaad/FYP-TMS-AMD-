using System.ComponentModel.DataAnnotations;

namespace TMS.Models.DTO.Department
{
    public class CreateDepartmentRequest
    {
        [Required]
        [MinLength(5, ErrorMessage = "Name at least 5 characters long!")]
        [MaxLength(100, ErrorMessage = "Name can't longer than 100 characters!")]
        public string Name { get; set; }
    }
}