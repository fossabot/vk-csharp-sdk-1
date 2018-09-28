using Newtonsoft.Json;

namespace Vk.CSharp.Sdk.Core.Models
{
    internal class ResponseError
    {
        [JsonProperty("error_code")]
        public int ErrorCode { get; set; }
    }
}