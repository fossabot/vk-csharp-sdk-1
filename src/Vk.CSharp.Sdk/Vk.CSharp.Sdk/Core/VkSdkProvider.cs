using System;
using Vk.CSharp.Sdk.Core.Mappers;
using Vk.CSharp.Sdk.Core.Modules;
using Vk.CSharp.Sdk.Enums;
using Vk.CSharp.Sdk.Modules;

namespace Vk.CSharp.Sdk.Core
{
    internal static class VkSdkProvider
    {
        public static VkApiVersion GetCurrentVersion() => VkApiVersion.V585;

        public static IAccount GetAccount() => LazyAccount.Value;
        public static IAds GetAds() => LazyAds.Value;

        private static readonly Lazy<IAccount> LazyAccount
            = new Lazy<IAccount>(CreateAccount);

        private static readonly Lazy<IAds> LazyAds
            = new Lazy<IAds>(CreateAds);

        private static Account CreateAccount()
            => new Account(new AccountMapper());

        private static Ads CreateAds()
            => new Ads(new AdsMapper());
    }
}