namespace XRPL.MrMoleService.Domain
{
    public class ReviewRequest
    {
        /// <summary> User wallet. Starts with "r" </summary>
        public string account { get; set; }
        /// <summary> Issuer </summary>
        public string issuer { get; set; }
        /// <summary> Token name </summary>
        public string token_name { get; set; }
        /// <summary> Feedback text (min: 10 chars, max: 1000) </summary>
        public string text { get; set; }
        /// <summary>
        /// Review value:<br/>
        /// -5 -> Negative Review<br/>
        /// 0 -> Neutral<br/>
        /// 5 -> Positive Review<br/>
        /// </summary>
        public int vote { get; set; }
    }
}
