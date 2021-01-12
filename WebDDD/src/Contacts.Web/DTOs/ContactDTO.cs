using System.ComponentModel.DataAnnotations;

namespace Contacts.Web.DTOs
{
    public class ContactDTO
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }
    }
}