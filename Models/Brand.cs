using ControlInventario.Shared.Models.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControlInventario.Shared.Models
{
    public class Brand : ISyncable
    {
        [Key]
        public int Id { get; set; }
        public bool IsSynced { get; set; } = false;

        [Required]
        public int InventoryId { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;
        public int CompanyId { get; set; }
    }
}