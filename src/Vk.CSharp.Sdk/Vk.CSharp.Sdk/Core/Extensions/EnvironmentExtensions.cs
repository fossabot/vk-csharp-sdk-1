using System;
using Vk.CSharp.Sdk.Models;

namespace Vk.CSharp.Sdk.Core.Extensions
{
    internal static class EnvironmentExtensions
    {
        public static VkSdkEnvironment GetClone(this VkSdkEnvironment environment)
        {
            return environment.Clone() as VkSdkEnvironment;
        }

        public static VkSdkEnvironment SetAccessToken(this VkSdkEnvironment environment, string accessToken)
        {
            if (string.IsNullOrWhiteSpace(accessToken))
                throw new ArgumentException(nameof(accessToken));

            environment.AccessToken = accessToken;

            return environment;
        }

        public static VkSdkEnvironment Clear(this VkSdkEnvironment environment)
        {
            environment.AccessToken = string.Empty;

            return environment;
        }
    }
}