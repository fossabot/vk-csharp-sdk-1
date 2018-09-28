using Vk.CSharp.Sdk.Core.Directors.Interfaces;
using Vk.CSharp.Sdk.Core.Mappers.Interfaces;
using Vk.CSharp.Sdk.Core.Modules.Base;
using Vk.CSharp.Sdk.Core.Wrappers.Interfaces;
using Vk.CSharp.Sdk.Models.Account.Parameters;
using Vk.CSharp.Sdk.Models.Account.Responses;
using Vk.CSharp.Sdk.Modules;

namespace Vk.CSharp.Sdk.Core.Modules
{
    // Ссылка: https://vk.com/dev/account

    internal class Account : Module<Account>, IAccount
    {
        public Account(IRequestExecutionWrapper wrapper, IRequestBuildDirector<Account> director)
            : base(wrapper, director)
        { }

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