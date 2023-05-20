namespace XRPL.MrMoleService.Domain;

public class Price
{
    public string uuid { get; set; }
    public string issuer { get; set; }
    public string currency { get; set; }
    public float xrp { get; set; }
    public float usd { get; set; }
    public float price24 { get; set; }
    public DateTime created_at { get; set; }
    public DateTime updated_at { get; set; }
}