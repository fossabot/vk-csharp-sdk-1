using System.Net.Http;
using System.Threading.Tasks;
using Vk.CSharp.Sdk.Core.Components.Interfaces;

namespace Vk.CSharp.Sdk.Core.Components
{
    internal class Browser : IBrowser
    {
        public async Task<string> GetResponseAsync(string request) =>
            await GetResponseInternalAsync(request).ConfigureAwait(false);

        private static async Task<string> GetResponseInternalAsync(string request) =>
            await new HttpClient()
                .GetStringAsync(request)
                .ConfigureAwait(false);
    }
}