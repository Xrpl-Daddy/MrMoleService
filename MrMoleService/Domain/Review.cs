namespace XRPL.MrMoleService.Domain;

public class Review
{
    public string uuid { get; set; }
    public string token_uuid { get; set; }
    public string user_uuid { get; set; }
    public string body { get; set; }
    public int vote { get; set; }
    public DateTime created_at { get; set; }
    public DateTime updated_at { get; set; }
}