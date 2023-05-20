namespace XRPL.MrMoleService.Domain;

public class AccountInfo
{
    public string uuid { get; set; }
    public string name { get; set; }
    public string email { get; set; }
    public string xumm_account { get; set; }
    public object extend_accounts { get; set; }
    public DateTime rate_expired_at { get; set; }
    public string subscribeType { get; set; }
    public DateTime created_at { get; set; }
    public DateTime updated_at { get; set; }
    public string tariff_cost { get; set; }
}