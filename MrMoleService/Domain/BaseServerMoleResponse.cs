using Newtonsoft.Json;

namespace XRPL.MrMoleService.Domain
{
    public class BaseServerMoleResponse<T> : IMoleResponse
    {
        public HttpResponseMessage Response { get; set; }
        [JsonProperty("data")]
        public T Data { get; set; }
    }
}
