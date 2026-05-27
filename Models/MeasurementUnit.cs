using System.ComponentModel.DataAnnotations;

namespace ControlInventario.Shared.Models
{
    public class MeasurementUnit
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string UnitName { get; set; } = string.Empty;
    }
}