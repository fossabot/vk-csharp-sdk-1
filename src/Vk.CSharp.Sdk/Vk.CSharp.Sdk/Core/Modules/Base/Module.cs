using Vk.CSharp.Sdk.Core.Directors.Interfaces;
using Vk.CSharp.Sdk.Core.Models;
using Vk.CSharp.Sdk.Core.Wrappers.Interfaces;

namespace Vk.CSharp.Sdk.Core.Modules.Base
{
    internal abstract class Module<TModule> where TModule : class
    {
        protected IRequestBuildDirector<TModule> RequestBuildDirector { get; }

        protected IRequestExecutionWrapper RequestExecutionWrapper { get; }

        protected Module(
            IRequestExecutionWrapper requestExecutionWrapper,
            IRequestBuildDirector<TModule> requestBuildDirector)
        {
            RequestBuildDirector = requestBuildDirector;
            RequestExecutionWrapper = requestExecutionWrapper;
        }

        protected Request ConstructRequest<TParameters>(
            TParameters parameters, string methodName, string accessToken)
            where TParameters : class
        {
            return RequestBuildDirector.Construct(
                new RequestData<TParameters>(parameters, methodName, accessToken)
            );
        }
    }
}