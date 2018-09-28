using System.Threading.Tasks;
using AutoMapper;
using Vk.CSharp.Sdk.Core.Components.Interfaces;
using Vk.CSharp.Sdk.Core.Executors;
using Vk.CSharp.Sdk.Core.Models;
using Vk.CSharp.Sdk.Core.Services;
using Vk.CSharp.Sdk.Core.Services.Interfaces;
using Vk.CSharp.Sdk.Core.Wrappers.Interfaces;

namespace Vk.CSharp.Sdk.Core.Wrappers
{
    internal class RequestExecutionWrapper : IRequestExecutionWrapper
    {
        private ITransformationService TransformationService { get; }
            = new TransformationService();

        private IBrowser Browser { get; }
        private IRuntimeMapper Mapper { get; }

        public RequestExecutionWrapper(IBrowser browser, IRuntimeMapper mapper)
        {
            Browser = browser;
            Mapper = mapper;
        }

        public async Task<TExternalResponse> ExecuteAsync<TInternalResponse, TExternalResponse>(Request request)
        {
            var response = await CreateRequestExecutor<TInternalResponse>()
                .ExecuteAsync(request)
                .ConfigureAwait(false);

            return Mapper.Map<TExternalResponse>(response);
        }

        private RequestExecutor<TResponse> CreateRequestExecutor<TResponse>()
        {
            return new RequestExecutor<TResponse>(TransformationService, Browser);
        }
    }
}