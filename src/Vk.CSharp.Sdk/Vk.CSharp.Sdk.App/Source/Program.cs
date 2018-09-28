using System;
using Vk.CSharp.Sdk.Enums;
using Vk.CSharp.Sdk.Home;
using Vk.CSharp.Sdk.Models;

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

            Environment = VkSdkProvider.GetSame()
                .GetEnvironment();

            Console.WriteLine(Environment.AccessToken);

            Console.ReadKey();
        }
    }
}