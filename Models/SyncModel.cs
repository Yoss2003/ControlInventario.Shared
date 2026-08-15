namespace ControlInventario.Shared.Models
{
    public class SyncModel
    {
        public bool IsSynced { get; set; } = true;
        public DateTime LastModified { get; set; } = DateTime.Now;
        public bool IsActive { get; set; } = true;
    }
}
