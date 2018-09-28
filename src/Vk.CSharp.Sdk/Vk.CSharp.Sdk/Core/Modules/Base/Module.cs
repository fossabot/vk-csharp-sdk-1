using Vk.CSharp.Sdk.Core.Mappers.Interfaces;

namespace Vk.CSharp.Sdk.Core.Modules.Base
{
    internal abstract class Module
    {
        protected IModuleMapper Mapper { get; set; }

        protected Module(IModuleMapper mapper)
        {
            Mapper = mapper;
        }
    }
}