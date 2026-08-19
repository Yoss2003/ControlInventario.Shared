namespace ControlInventario.Shared.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string BusinessName { get; set; } = string.Empty;
        public string Ruc { get; set; } = string.Empty;

        public string? LogoUrl { get; set; }
        public string? PrimaryColorHex { get; set; }

        public bool IsActive { get; set; } = true;
        public DateTime RegistrationDate { get; set; } = DateTime.Now;
        
        // [JsonIgnore] // Úsalo si en el futuro te da problemas de bucle
        public List<User>? Users { get; set; }
    }
}
