using Vk.CSharp.Sdk.Enums;
using Vk.CSharp.Sdk.Home;
using Xunit;

namespace Vk.CSharp.Sdk.Tests.References
{
    public class ReferencesTests
    {
        [Fact]
        public void References_VkSdk()
        {
            // Get New
            // Get Same (последний полученный интерфейс)
            Assert.Same(VkSdkProvider.GetNew(), VkSdkProvider.GetSame());

            // Get Same
            // Get Same (последний полученный интерфейс)
            Assert.Same(VkSdkProvider.GetSame(), VkSdkProvider.Get(ReceiveMode.Same));

            // Get New
            // Get New (новый интрерфейс)
            Assert.NotSame(VkSdkProvider.GetNew(), VkSdkProvider.GetNew());

            // Get Same
            // Get New (новый интрерфейс)
            Assert.NotSame(VkSdkProvider.GetSame(), VkSdkProvider.Get(ReceiveMode.New));
        }

        [Fact]
        public void References_Modules()
        {
            var newSdk = VkSdkProvider.GetNew();
            var sameSdk = VkSdkProvider.GetSame();

            // Модули не хранят состояние.
            Assert.Same(newSdk.GetAccount(), sameSdk.GetAccount());
            Assert.Same(newSdk.GetAds(), sameSdk.GetAds());
            Assert.Same(newSdk.GetApps(), sameSdk.GetApps());
        }
    }
}