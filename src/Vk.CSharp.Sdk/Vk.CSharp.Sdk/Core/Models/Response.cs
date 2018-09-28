using Newtonsoft.Json;

namespace Vk.CSharp.Sdk.Core.Models
{
    internal class Response<TData>
    {
        [JsonProperty("response")]
        public TData Data { get; set; }

        [JsonProperty("error")]
        public ResponseError Error { get; set; }
    }
}