using Vk.CSharp.Sdk.Core.Directors.Interfaces;
using Vk.CSharp.Sdk.Core.Modules.Base;
using Vk.CSharp.Sdk.Core.Wrappers.Interfaces;
using Vk.CSharp.Sdk.Modules;

namespace Vk.CSharp.Sdk.Core.Modules
{
    // Ссылка: https://vk.com/dev/apps

    internal class Apps : Module<Apps>, IApps
    {
        public Apps(IRequestExecutionWrapper wrapper, IRequestBuildDirector<Apps> director)
            : base(wrapper, director)
        { }
    }
}