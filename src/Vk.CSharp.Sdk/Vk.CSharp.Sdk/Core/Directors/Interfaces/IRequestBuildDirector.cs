using Vk.CSharp.Sdk.Core.Builders.Interfaces;
using Vk.CSharp.Sdk.Core.Models;

namespace Vk.CSharp.Sdk.Core.Directors.Interfaces
{
    internal interface IRequestBuildDirector<TModule> where TModule : class
    {
        IRequestBuilder<TModule> Builder { get; set; }

        Request Construct<TParameters>(RequestData<TParameters> data)
            where TParameters : class;
    }
}