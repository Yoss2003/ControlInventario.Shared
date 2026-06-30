using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControlInventario.Shared.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required] public string FirstName { get; set; } = string.Empty;
        [Required] public string LastName { get; set; } = string.Empty;
        [Required] public string Username { get; set; } = string.Empty;
        [Required] public string Password { get; set; } = string.Empty;
        public string? Email { get; set; }

        public int? Age { get; set; }
        public string? BirthDate { get; set; } = string.Empty;
        public string? HireDate { get; set; } = string.Empty;

        // CAMPOS RELACIONALES
        public string? PhoneNumber { get; set; }
        public string? ProfilePictureUrl { get; set; }

        // CAMPOS PARA GOOGLE AUTHENTICATOR
        public bool IsActive { get; set; } = true;
        public string? TwoFactorSecret { get; set; }
        public bool IsTwoFactorEnabled { get; set; }

        // RELACIONES HACIA LAS TABLAS (Foreign Keys)
        public int? RoleId { get; set; }
        public virtual Role? Role { get; set; }
        public int? JobPositionId { get; set; }
        public int? AreaId { get; set; }
        public int? ContractTypeId { get; set; }

        [NotMapped]
        public string? RoleName { get; set; }
        public int? CompanyId { get; set; }
        public int StatusId { get; set; } = 2;
        public bool MustChangePassword { get; set; } = true;
    }
}