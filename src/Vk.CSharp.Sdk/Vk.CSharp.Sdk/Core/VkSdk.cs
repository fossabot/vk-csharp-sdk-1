using System.Runtime.CompilerServices;
using Vk.CSharp.Sdk.Core.Extensions;
using Vk.CSharp.Sdk.Enums;
using Vk.CSharp.Sdk.Home;
using Vk.CSharp.Sdk.Models;
using Vk.CSharp.Sdk.Modules;

[assembly: InternalsVisibleTo("Vk.CSharp.Sdk.Tests")]
[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2")]

namespace Vk.CSharp.Sdk.Core
{
    internal class VkSdk : IVkSdk
    {
        private VkSdkEnvironment Environment { get; }
            = new VkSdkEnvironment(VkSdkProvider.GetCurrentVersion());

        public VkApiVersion GetCurrentVkApiVersion()
        {
            return Environment.Version;
        }

        public VkSdkEnvironment GetEnvironment()
        {
            return Environment.GetClone();
        }

        public AuthorizationResult Authorize(AuthorizationData data)
        {
            Deauthorize();

            if (!string.IsNullOrEmpty(data.AccessToken))
            {
                Environment.SetAccessToken(data.AccessToken);

                return new AuthorizationResult { Success = true };
            }

            return new AuthorizationResult { Success = false };
        }

        public void Deauthorize()
        {
            Environment.Clear();
        }

        public IAccount GetAccount() => VkSdkProvider.GetAccount();
        public IAds GetAds() => VkSdkProvider.GetAds();
    }
}