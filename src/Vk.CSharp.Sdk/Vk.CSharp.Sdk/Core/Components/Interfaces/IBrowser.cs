using System.Threading.Tasks;

namespace Vk.CSharp.Sdk.Core.Components.Interfaces
{
    internal interface IBrowser
    {
        Task<string> GetResponseAsync(string request);
    }
}