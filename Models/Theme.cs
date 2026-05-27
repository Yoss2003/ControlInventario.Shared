using System.ComponentModel.DataAnnotations;

namespace ControlInventario.Shared.Models
{
    public class Theme
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100)]
        public string? ThemeName { get; set; }
    }
}