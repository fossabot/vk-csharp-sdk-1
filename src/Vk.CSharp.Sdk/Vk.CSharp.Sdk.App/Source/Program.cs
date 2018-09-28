using System;
using Vk.CSharp.Sdk.Enums;
using Vk.CSharp.Sdk.Home;
using Vk.CSharp.Sdk.Models;
using Vk.CSharp.Sdk.Models.Account.Parameters;
using Vk.CSharp.Sdk.Models.Ads.Parameters;

namespace Vk.CSharp.Sdk.App.Source
{
    internal class Program
    {
        private static string AccessToken { get; } = "access_token";

        private static VkApiVersion CurrentVersion { get; } =
            VkSdkProvider.Get(ReceiveMode.Same)
                .GetCurrentVkApiVersion();

        private static VkSdkEnvironment Environment { get; set; }

        private static void Main()
        {
            Console.WriteLine(CurrentVersion);

            VkSdkProvider.GetSame()
                .Authorize(new AuthorizationData(AccessToken));

            VkSdkProvider.GetSame()
                .GetAccount()
                .Ban(new ParametersBan());

            VkSdkProvider.GetSame()
                .GetAds()
                .AddOfficeUsers(new ParametersAddOfficeUsers());

            Environment = VkSdkProvider.GetSame()
                .GetEnvironment();

            Console.WriteLine(Environment.AccessToken);

            VkSdkProvider.GetSame()
                .Deauthorize();

            Environment = VkSdkProvider.GetSame()
                .GetEnvironment();

            Console.WriteLine(string.IsNullOrWhiteSpace(Environment.AccessToken));

            Console.ReadKey();
        }
    }
}