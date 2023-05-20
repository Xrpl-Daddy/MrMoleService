namespace XRPL.MrMoleService.Domain;

public class VoteRequest
{
    /// <summary> User wallet. Starts with "r" </summary>
    public string account { get; set; }
    /// <summary> Issuer </summary>
    public string issuer { get; set; }
    /// <summary> Token name </summary>
    public string token_name { get; set; }
    /// <summary>
    /// Review value:<br/>
    /// -1 - negative <br/>
    /// 0 - neutral<br/>
    /// 1 - positive<br/>
    /// </summary>
    public int vote { get; set; }
}