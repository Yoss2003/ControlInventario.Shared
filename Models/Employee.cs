using ControlInventario.Shared.Models.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ControlInventario.Shared.Models
{
    public class Employee : ISoftDelete
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? DNI { get; set; }
        public int? Age { get; set; }
        public string? BirthDate { get; set; }
        public int? JobPositionId { get; set; }
        public int? AreaId { get; set; }
        public string? HireDate { get; set; }
        public int? ContractTypeId { get; set; }
        public int StatusId { get; set; }
        public int CompanyId { get; set; }

        [JsonIgnore]
        public User? User { get; set; }

        [NotMapped]
        public string? PictureUrl { get; set; }
        public bool IsActive { get; set; } = true;

        public DateTime? DeletionDate { get; set; }
        public string? DeletionUser { get; set; }
        [NotMapped]
        public string Initial => string.IsNullOrEmpty(FirstName) ? "" : FirstName[0].ToString().ToUpper();
    }
}