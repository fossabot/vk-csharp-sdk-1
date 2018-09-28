using Vk.CSharp.Sdk.Core.Mappers.Interfaces;
using Vk.CSharp.Sdk.Core.Modules.Base;
using Vk.CSharp.Sdk.Models.Ads.Parameters;
using Vk.CSharp.Sdk.Models.Ads.Responses;
using Vk.CSharp.Sdk.Modules;

namespace Vk.CSharp.Sdk.Core.Modules
{
    // Ссылка: https://vk.com/dev/ads

    internal class Ads : Module, IAds
    {
        public Ads(IModuleMapper mapper) : base(mapper) { }

        public ResponseAddOfficeUsers AddOfficeUsers(ParametersAddOfficeUsers parameters)
        {
            return new ResponseAddOfficeUsers();
        }
    }
}