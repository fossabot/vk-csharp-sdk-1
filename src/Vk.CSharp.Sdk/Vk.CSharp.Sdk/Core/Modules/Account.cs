using Vk.CSharp.Sdk.Core.Mappers.Interfaces;
using Vk.CSharp.Sdk.Core.Modules.Base;
using Vk.CSharp.Sdk.Models.Account.Parameters;
using Vk.CSharp.Sdk.Models.Account.Responses;
using Vk.CSharp.Sdk.Modules;

namespace Vk.CSharp.Sdk.Core.Modules
{
    // Ссылка: https://vk.com/dev/account

    internal class Account : Module, IAccount
    {
        public Account(IModuleMapper mapper) : base(mapper) { }

        public ResponseBan Ban(ParametersBan parameters)
        {
            return new ResponseBan();
        }

        public ResponseChangePassword ChangePassword(ParametersChangePassword parameters)
        {
            return new ResponseChangePassword();
        }

        public ResponseGetActiveOffers GetActiveOffers(ResponseGetActiveOffers parameters)
        {
            return new ResponseGetActiveOffers();
        }
    }
}