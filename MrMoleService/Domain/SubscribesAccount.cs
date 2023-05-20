namespace XRPL.MrMoleService.Domain;

public class SubscribesAccount
{
    public string[] accounts { get; set; }
    public string type { get; set; }
    public DateTime? expired_at { get; set; }
}