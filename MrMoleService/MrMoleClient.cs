using XRPL.MrMoleService.Domain;

namespace XRPL.MrMoleService
{
    /// <summary> client to connect to <a>https://mrmole.org/api</a></summary>
    public class MrMoleClient : BaseMoleDataClient
    {
        /// <summary>
        /// https://mrmole.org/api
        /// Api Client
        /// </summary>
        /// <param name="waitWhenLimit">If the maximum number of requests per minute has been exceeded, either waits for the limit to be reset or returns null</param>
        /// <param name="apiKey">api key</param>
        /// <param name="BaseServiceAddress">server address</param>
        public MrMoleClient(bool waitWhenLimit, string apiKey, string BaseServiceAddress = "https://mrmole.org/") : base(waitWhenLimit, apiKey, BaseServiceAddress)
        {
        }

        /// <summary>Account List with Subscription  </summary>
        /// <returns> list of <seealso cref="SubscribesAccount"/></returns>
        public async Task<BaseServerMoleResponse<List<SubscribesAccount>>> GetSubscribedAccounts(CancellationToken Cancel = default)
        {
            if (!await CheckLimit(Cancel))
                return null;
            var response = await GetAsync<BaseServerMoleResponse<List<SubscribesAccount>>>($"api/v{ApiVersion}/account/subscribes", Cancel);
            return response;
        }
        /// <summary>Current account information</summary>
        /// <returns> account information <seealso cref="AccountInfo"/></returns>
        public async Task<BaseServerMoleResponse<AccountInfo>> GetCurrentAccountInfo(CancellationToken Cancel = default)
        {
            if (!await CheckLimit(Cancel))
                return null;
            var response = await GetAsync<BaseServerMoleResponse<AccountInfo>>($"api/v{ApiVersion}/account/me", Cancel);
            return response;
        }
        /// <summary>Issuer information</summary>
        /// <returns> Issuer information <seealso cref="IssuerInfo"/></returns>
        public async Task<BaseServerMoleResponse<IssuerInfo>> GetIssuerInfo(string Issuer, CancellationToken Cancel = default)
        {
            if (string.IsNullOrWhiteSpace(Issuer))
                return null;
            if (!await CheckLimit(Cancel))
                return null;
            var response = await GetAsync<BaseServerMoleResponse<IssuerInfo>>($"api/v{ApiVersion}/issuer/{Issuer}?relations=tokens,links,newsPublished", Cancel);
            return response;
        }
        /// <summary>Token information</summary>
        /// <returns> Token information <seealso cref="TokenInfo"/></returns>
        public async Task<BaseServerMoleResponse<TokenInfo>> GetTokenInfo(string Issuer, string Token, CancellationToken Cancel = default)
        {
            if (string.IsNullOrWhiteSpace(Token) || string.IsNullOrWhiteSpace(Issuer))
                return null;
            if (!await CheckLimit(Cancel))
                return null;
            var response = await GetAsync<BaseServerMoleResponse<TokenInfo>>($"api/v{ApiVersion}/token/{Issuer}/{Token}?relations=issuer,reviews,votes", Cancel);
            return response;
        }
        /// <summary>Review information</summary>
        /// <returns> Review information <seealso cref="Review"/></returns>
        public async Task<BaseServerMoleResponse<Review>> GetReview(string Review_uuiid, CancellationToken Cancel = default)
        {
            if (string.IsNullOrWhiteSpace(Review_uuiid))
                return null;
            if (!await CheckLimit(Cancel))
                return null;
            var response = await GetAsync<BaseServerMoleResponse<Review>>($"api/v{ApiVersion}/review/{Review_uuiid}", Cancel);
            return response;
        }
        /// <summary>Add new Review</summary>
        /// <returns> Review information <seealso cref="Review"/></returns>
        public async Task<BaseServerMoleResponse<Review>> AddReview(ReviewRequest Review, CancellationToken Cancel = default)
        {
            if (Review is null || string.IsNullOrWhiteSpace(Review.account) || string.IsNullOrWhiteSpace(Review.issuer) || string.IsNullOrWhiteSpace(Review.token_name))
                return null;
            if (!await CheckLimit(Cancel))
                return null;
            var response = await PostAsync<ReviewRequest, BaseServerMoleResponse<Review>>($"api/v{ApiVersion}/review/add", Review, Cancel);
            return response;
        }
        /// <summary>Add vote</summary>
        /// <returns> vote information <seealso cref="Review"/></returns>
        public async Task<BaseServerMoleResponse<Vote>> AddVote(VoteRequest Vote, CancellationToken Cancel = default)
        {
            if (Vote is null || string.IsNullOrWhiteSpace(Vote.account) || string.IsNullOrWhiteSpace(Vote.issuer) || string.IsNullOrWhiteSpace(Vote.token_name))
                return null;
            if (!await CheckLimit(Cancel))
                return null;
            var response = await PostAsync<VoteRequest, BaseServerMoleResponse<Vote>>($"api/v{ApiVersion}/vote/add", Vote, Cancel);
            return response;
        }

    }
}
