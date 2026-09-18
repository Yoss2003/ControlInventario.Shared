namespace ControlInventario.Shared.Models.Interfaces
{
    public interface ISyncable
    {
        int Id { get; set; }
        bool IsSynced { get; set; }
    }
}