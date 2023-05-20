namespace XRPL.MrMoleService.Domain;

public class Vote
{
    public string uuid { get; set; }
    public string token_uuid { get; set; }
    public int value { get; set; }
    public DateTime created_at { get; set; }
    public DateTime updated_at { get; set; }
}