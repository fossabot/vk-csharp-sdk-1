using Vk.CSharp.Sdk.Models.Account.Parameters;
using Vk.CSharp.Sdk.Models.Account.Responses;

namespace Vk.CSharp.Sdk.Modules
{
    // Ссылка: https://vk.com/dev/account

    /// <summary>
    /// Модуль для работы с аккаунтом.
    /// </summary>
    public interface IAccount
    {
        /// <summary>
        /// Добавляет пользователя или группу в черный список.
        /// </summary>
        ResponseBan Ban(ParametersBan parameters);

        /// <summary>
        /// Позволяет сменить пароль пользователя.
        /// </summary>
        ResponseChangePassword ChangePassword(ParametersChangePassword parameters);

        /// <summary>
        /// Возвращает список активных рекламных предложений (офферов).
        /// </summary>
        ResponseGetActiveOffers GetActiveOffers(ResponseGetActiveOffers parameters);
    }
}