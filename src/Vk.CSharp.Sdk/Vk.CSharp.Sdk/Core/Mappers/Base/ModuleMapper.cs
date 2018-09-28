using System;
using System.Linq;
using AutoMapper;
using Vk.CSharp.Sdk.Core.Mappers.Interfaces;

namespace Vk.CSharp.Sdk.Core.Mappers.Base
{
    internal abstract class ModuleMapper : IModuleMapper
    {
        public IRuntimeMapper Mapper { get; set; }

        protected ModuleMapper()
        {
            Mapper = new Mapper(new MapperConfiguration(Configure));
        }

        protected abstract void Configure(IMapperConfigurationExpression expression);

        protected static DateTime ConvertToDateTime(long date) =>
            new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc)
                .AddSeconds(date)
                .ToLocalTime();

        protected static bool ConvertToBool(int value)
            => value != 0;

        protected static DateTime ConvertToDateTime(string date)
            => Convert.ToDateTime(date);

        protected static string Register(string value)
        {
            value = value.ToLower();
            return char.ToUpper(value.First()) + value.Substring(1);
        }
    }
}