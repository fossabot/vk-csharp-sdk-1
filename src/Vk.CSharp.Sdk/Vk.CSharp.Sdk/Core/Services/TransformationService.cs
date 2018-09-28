using Newtonsoft.Json;
using Vk.CSharp.Sdk.Core.Services.Interfaces;

namespace Vk.CSharp.Sdk.Core.Services
{
    internal class TransformationService : ITransformationService
    {
        public TObject Deserialize<TObject>(string json)
        {
            return JsonConvert.DeserializeObject<TObject>(json);
        }

        public string Serialize<TObject>(TObject @object)
        {
            return JsonConvert.SerializeObject(@object);
        }
    }
}