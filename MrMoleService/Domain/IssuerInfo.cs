namespace XRPL.MrMoleService.Domain;

public class IssuerInfo
{
    public string uuid { get; set; }
    public string slug { get; set; }
    public int verified { get; set; }
    public string name { get; set; }
    public string account { get; set; }
    public string parent { get; set; }
    public string explorer { get; set; }
    public string tx_hash { get; set; }
    public object description { get; set; }
    public string file_logotype { get; set; }
    public int kyc { get; set; }
    public object user_uuid { get; set; }
    public object verified_user_uuid { get; set; }
    public DateTime created_at { get; set; }
    public DateTime updated_at { get; set; }
    public Token[] tokens { get; set; }
    public Link[] links { get; set; }
    public object[] news_published { get; set; }
}