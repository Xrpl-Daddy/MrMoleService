namespace XRPL.MrMoleService.Domain;

public class Token
{
    public string uuid { get; set; }
    public string issuer_uuid { get; set; }
    public string file_logotype { get; set; }
    public string name { get; set; }
    public string account { get; set; }
    public string currency { get; set; }
    public string currency_default { get; set; }
    public float amount { get; set; }
    public int trustlines { get; set; }
    public int offers { get; set; }
    public DateTime created_date { get; set; }
    public object created_hash { get; set; }
    public DateTime moderation_at { get; set; }
    public DateTime created_at { get; set; }
    public DateTime updated_at { get; set; }
    public float vote { get; set; }
    public int rating { get; set; }
    public int change24 { get; set; }
    public int expert_rating { get; set; }
    public object description { get; set; }
    public object[] translations { get; set; }
    public string page_url { get; set; }
    public Price price { get; set; }
}