namespace ControlInventario.Shared.Models.DTO
{
    public class ChangePasswordRequest
    {
        public int UserId { get; set; }
        public required string NewPassword { get; set; }
    }
}
