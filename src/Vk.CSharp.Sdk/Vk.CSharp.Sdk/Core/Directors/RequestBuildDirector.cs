using Vk.CSharp.Sdk.Core.Builders.Interfaces;
using Vk.CSharp.Sdk.Core.Directors.Interfaces;
using Vk.CSharp.Sdk.Core.Models;

namespace Vk.CSharp.Sdk.Core.Directors
{
    internal class RequestBuildDirector<TModule> : IRequestBuildDirector<TModule>
        where TModule : class
    {
        public IRequestBuilder<TModule> Builder { get; set; }

        public RequestBuildDirector(IRequestBuilder<TModule> builder)
        {
            Builder = builder;
        }

        public Request Construct<TParameters>(RequestData<TParameters> data)
            where TParameters : class
        {
            return Builder
                .Initialize(data)
                .BuildModuleAndMethod()
                .BuildQuestionMark()
                .BuildParameters(data)
                .BuildDuty()
                .GetRequest(data);
        }
    }
}