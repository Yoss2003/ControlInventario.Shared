using ControlInventario.Shared.Models;

public class User
{
    public int Id { get; set; }
    public string? Username { get; set; }
    public string? Password { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
    public string? ProfilePictureUrl { get; set; }
    public bool IsActive { get; set; }

    // 🚨 BORRAR: FirstName, LastName, Age, BirthDate, JobPositionId, AreaId, HireDate, ContractTypeId 🚨

    // CAMPOS DE SEGURIDAD
    public int RoleId { get; set; }
    public Role? Role { get; set; }
    public int? CompanyId { get; set; }
    public int StatusId { get; set; } = 2;
    public bool MustChangePassword { get; set; } = true;
    public string? TwoFactorSecret { get; set; }
    public bool IsTwoFactorEnabled { get; set; }

    // 🌟 NUEVO: El puente hacia sus datos biográficos
    public Employee? Employee { get; set; }
    public DateTime? CreatedAt { get; set; } = DateTime.Now;
}