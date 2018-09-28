using AutoMapper;

namespace Vk.CSharp.Sdk.Core.Mappers.Interfaces
{
    internal interface IModuleMapper
    {
        IRuntimeMapper Mapper { get; set; }
    }
}