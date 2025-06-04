using System.ComponentModel.DataAnnotations;

namespace GenericBlazorApp.Web.Models
{
    public class Person
    {
        [Required(ErrorMessage = "Full Name is required")]
        [StringLength(128, ErrorMessage = "Full Name cannot exceed 128 characters")]
        public string FullName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Type is required")]
        public PersonType Type { get; set; }

        [Required(ErrorMessage = "Birth Date is required")]
        public DateTime? BirthDate { get; set; }

        public string? Notes { get; set; }
    }

    public enum PersonType
    {
        Mother,
        Child
    }
}