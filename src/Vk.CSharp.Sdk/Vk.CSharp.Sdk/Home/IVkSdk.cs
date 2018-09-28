using Vk.CSharp.Sdk.Enums;
using Vk.CSharp.Sdk.Models;
using Vk.CSharp.Sdk.Modules;

namespace Vk.CSharp.Sdk.Home
{
    /// <summary>
    /// Интерфейс для взаимодействия с ВКонтакте.
    /// </summary>
    public interface IVkSdk
    {
        /// <summary>
        /// Возвращает текущую версию API ВКонтакте.
        /// </summary>
        /// <returns>Текущая версия API ВКонтакте.</returns>
        VkApiVersion GetCurrentVkApiVersion();

        /// <summary>
        /// Возвращает окружение.
        /// </summary>
        /// <returns>Окружение.</returns>
        VkSdkEnvironment GetEnvironment();

        /// <summary>
        /// Выполняет авторизацию.
        /// </summary>
        /// <param name="data">Данные для авторизации.</param>
        /// <returns>Результат авторизации.</returns>
        AuthorizationResult Authorize(AuthorizationData data);

        /// <summary>
        /// Выполняет деавторизацию (будет очищено окружение).
        /// </summary>
        void Deauthorize();

        /// <summary>
        /// Возвращает интерфейс для работы с аккаунтом.
        /// </summary>
        IAccount GetAccount();

        /// <summary>
        /// Возвращает интерфейс для работы с рекламным кабинетом.
        /// </summary>
        IAds GetAds();

        /// <summary>
        /// Возвращает интерфейс для работы с приложениями.
        /// </summary>
        IApps GetApps();
    }
}