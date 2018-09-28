using System;
using Vk.CSharp.Sdk.Core.Builders;
using Vk.CSharp.Sdk.Core.Components;
using Vk.CSharp.Sdk.Core.Directors;
using Vk.CSharp.Sdk.Core.Mappers;
using Vk.CSharp.Sdk.Core.Modules;
using Vk.CSharp.Sdk.Core.Wrappers;
using Vk.CSharp.Sdk.Enums;
using Vk.CSharp.Sdk.Modules;

namespace Vk.CSharp.Sdk.Core
{
    internal static class VkSdkProvider
    {
        public static VkApiVersion GetCurrentVkApiVersion() => VkApiVersion.V585;

        public static IAccount GetAccount() => LazyAccount.Value;
        public static IAds GetAds() => LazyAds.Value;
        public static IApps GetApps() => LazyApps.Value;

        private static readonly Lazy<IAccount> LazyAccount
            = new Lazy<IAccount>(CreateAccount);

        private static readonly Lazy<IAds> LazyAds
            = new Lazy<IAds>(CreateAds);

        private static readonly Lazy<IApps> LazyApps
            = new Lazy<IApps>(CreateApps);

        private static Account CreateAccount()
        {
            return new Account(
                new RequestExecutionWrapper(
                    new Browser(),
                    new AccountMapper().Mapper
                ),
                new RequestBuildDirector<Account>(
                    new RequestBuilder<Account>()
                )
            );
        }

        private static Ads CreateAds()
        {
            return new Ads(
                new RequestExecutionWrapper(
                    new Browser(),
                    new AccountMapper().Mapper
                ),
                new RequestBuildDirector<Ads>(
                    new RequestBuilder<Ads>()
                )
            );
        }

        private static Apps CreateApps()
        {
            return new Apps(
                new RequestExecutionWrapper(
                    new Browser(),
                    new AccountMapper().Mapper
                ),
                new RequestBuildDirector<Apps>(
                    new RequestBuilder<Apps>()
                )
            );
        }
    }
}