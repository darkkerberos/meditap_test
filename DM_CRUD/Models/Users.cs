using System.ComponentModel.DataAnnotations;

namespace DM_CRUD.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        public string Name { get; set; }

        // Add other properties as needed
    }
}