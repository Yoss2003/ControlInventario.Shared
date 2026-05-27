using System.ComponentModel.DataAnnotations;

namespace ControlInventario.Shared.Models
{ 
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int InventoryId { get; set; }

        public int? ParentCategoryId { get; set; }

        public string? TrackingMode { get; set; }

        public string? NamingMethod { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; } = string.Empty;

        public string? Description { get; set; }

        [Required]
        public int IsReturnable { get; set; } = 1;

        public DateTime? CreationDate { get; set; }
        public string? CreationUser { get; set; }
        public DateTime? ModificationDate { get; set; }
        public string? ModificationUser { get; set; }
        public DateTime? DeletionDate { get; set; }
        public string? DeletionUser { get; set; }
    }
}