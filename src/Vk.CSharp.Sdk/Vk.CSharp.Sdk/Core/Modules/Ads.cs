using Vk.CSharp.Sdk.Core.Directors.Interfaces;
using Vk.CSharp.Sdk.Core.Modules.Base;
using Vk.CSharp.Sdk.Core.Wrappers.Interfaces;
using Vk.CSharp.Sdk.Models.Ads.Parameters;
using Vk.CSharp.Sdk.Models.Ads.Responses;
using Vk.CSharp.Sdk.Modules;

namespace Vk.CSharp.Sdk.Core.Modules
{
    // Ссылка: https://vk.com/dev/ads

    internal class Ads : Module<Ads>, IAds
    {
        public Ads(IRequestExecutionWrapper wrapper, IRequestBuildDirector<Ads> director)
            : base(wrapper, director)
        { }

        public ResponseAddOfficeUsers AddOfficeUsers(ParametersAddOfficeUsers parameters)
        {
            return new ResponseAddOfficeUsers();
        }
    }
}