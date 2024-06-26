using System.ComponentModel.DataAnnotations;

namespace LupoonWeb.Models.Domain
{
    public class Tag
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Display Name is required")]
        public string DisplayName { get; set; }

        public ICollection<BlogPost> BlogPost { get; set; }
    }
}
