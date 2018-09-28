using Vk.CSharp.Sdk.Core.Models;

namespace Vk.CSharp.Sdk.Core.Builders.Interfaces
{
    internal interface IRequestBuilder<TModule> where TModule : class
    {
        IRequestBuilder<TModule> Initialize<TParameters>(RequestData<TParameters> data)
            where TParameters : class;

        IRequestBuilder<TModule> BuildModuleAndMethod();

        IRequestBuilder<TModule> BuildQuestionMark();

        IRequestBuilder<TModule> BuildParameters<TParameters>(RequestData<TParameters> data)
            where TParameters : class;

        IRequestBuilder<TModule> BuildDuty();

        Request GetRequest<TParameters>(RequestData<TParameters> data)
            where TParameters : class;
    }
}