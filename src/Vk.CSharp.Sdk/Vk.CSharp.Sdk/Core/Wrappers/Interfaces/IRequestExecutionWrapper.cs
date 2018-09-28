using System.Threading.Tasks;
using Vk.CSharp.Sdk.Core.Models;

namespace Vk.CSharp.Sdk.Core.Wrappers.Interfaces
{
    internal interface IRequestExecutionWrapper
    {
        Task<TExternalResponse> ExecuteAsync<TInternalResponse, TExternalResponse>(Request request);
    }
}