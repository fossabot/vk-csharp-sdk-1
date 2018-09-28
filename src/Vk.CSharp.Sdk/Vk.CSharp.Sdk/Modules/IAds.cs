using Vk.CSharp.Sdk.Models.Ads.Parameters;
using Vk.CSharp.Sdk.Models.Ads.Responses;

namespace Vk.CSharp.Sdk.Modules
{
    // Ссылка: https://vk.com/dev/ads

    /// <summary>
    /// Модуль для работы с рекламным кабинетом.
    /// </summary>
    public interface IAds
    {
        /// <summary>
        /// Добавляет администраторов и (или) наблюдателей в рекламный кабинет.
        /// </summary>
        ResponseAddOfficeUsers AddOfficeUsers(ParametersAddOfficeUsers parameters);
    }
}