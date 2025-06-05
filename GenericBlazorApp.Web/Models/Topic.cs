using System.ComponentModel.DataAnnotations;

namespace GenericBlazorApp.Web.Models
{
    public class Topic
    {
        [Required(ErrorMessage = "Summary is required")]
        [StringLength(128, ErrorMessage = "Summary cannot exceed 128 characters")]
        public string Summary { get; set; } = string.Empty;

        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage = "Target Date is required")]
        public DateTime? TargetDate { get; set; }
    }
}