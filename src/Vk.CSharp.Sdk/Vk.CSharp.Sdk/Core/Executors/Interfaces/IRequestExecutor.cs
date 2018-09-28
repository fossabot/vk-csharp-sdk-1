using System.Threading.Tasks;
using Vk.CSharp.Sdk.Core.Models;

namespace Vk.CSharp.Sdk.Core.Executors.Interfaces
{
    internal interface IRequestExecutor<TResponse>
    {
        Task<TResponse> ExecuteAsync(Request request);
    }
}