using System.ComponentModel.DataAnnotations;

namespace ControlInventario.Shared.Models
{
    public class Movement
    {
        [Key]
        public int Id { get; set; }
        [Required] public int ArticleId { get; set; }
        public int? EmployeeId { get; set; }
        [Required] public int ActionId { get; set; }
        [Required] public string MovementDate { get; set; } = string.Empty;
        public string? Observation { get; set; }
        public decimal? Amount { get; set; }
        public string? Recipient { get; set; }
        public decimal? SalePrice { get; set; }
        public string? DocumentNumber { get; set; }
        public string? PaymentMethod { get; set; }
        public string? VoucherType { get; set; }
        public string? CustomerPhone { get; set; }
        public string? CustomerEmail { get; set; }
        public int CompanyId { get; set; }
    }
}