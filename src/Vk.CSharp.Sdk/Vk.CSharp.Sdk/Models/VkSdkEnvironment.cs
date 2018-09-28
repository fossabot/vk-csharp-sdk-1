using Vk.CSharp.Sdk.Enums;

namespace Vk.CSharp.Sdk.Models
{
    /// <summary>
    /// Окружение.
    /// </summary>
    public class VkSdkEnvironment
    {
        /// <summary>
        /// Версия.
        /// </summary>
        public VkApiVersion Version { get; set; }

        /// <summary>
        /// Ключ доступа.
        /// </summary>
        public string AccessToken { get; set; } = string.Empty;

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="VkSdkEnvironment" />.
        /// </summary>
        public VkSdkEnvironment() { }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="VkSdkEnvironment" />.
        /// </summary>
        public VkSdkEnvironment(VkApiVersion version)
        {
            Version = version;
        }

        /// <summary>
        /// Выполняет копию объекта (клонирует).
        /// </summary>
        public object Clone()
        {
            return new VkSdkEnvironment
            {
                Version = Version,
                AccessToken = AccessToken
            };
        }
    }
}