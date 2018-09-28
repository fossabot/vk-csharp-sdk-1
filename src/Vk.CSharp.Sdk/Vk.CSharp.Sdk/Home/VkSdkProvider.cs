using System;
using Vk.CSharp.Sdk.Core;
using Vk.CSharp.Sdk.Enums;

namespace Vk.CSharp.Sdk.Home
{
    /// <summary>
    /// Провайдер для обеспечения взаимодействия с ВКонтакте.
    /// </summary>
    public static class VkSdkProvider
    {
        private static Lazy<IVkSdk> _lazy = CreateNewLazy();
        
        private static Lazy<IVkSdk> CreateNewLazy() =>
            new Lazy<IVkSdk>(() => new VkSdk());

        /// <summary>
        /// Возвращает интерфейс для взаимодействия с ВКонтакте.
        /// </summary>
        /// <returns>Интерфейс для взаимодействия с ВКонтакте.</returns>
        public static IVkSdk Get(ReceiveMode mode)
        {
            switch (mode)
            {
                case ReceiveMode.New:
                {
                    if (_lazy.IsValueCreated)
                        _lazy = CreateNewLazy();

                    return _lazy.Value;
                }
                case ReceiveMode.Same:
                {
                    return _lazy.Value;
                }
                default:
                {
                    throw new ArgumentOutOfRangeException(nameof(mode));
                }
            }
        }

        /// <summary>
        /// Возвращает новый интерфейс для взаимодействия с ВКонтакте.
        /// Очищается окружение, необходимо заново авторизоваться.
        /// </summary>
        /// <returns>Интерфейс для взаимодействия с ВКонтакте.</returns>
        public static IVkSdk GetNew() =>
            Get(ReceiveMode.New);

        /// <summary>
        /// Возвращает последний полученный интерфейс для взаимодействия с ВКонтакте.
        /// Сохраняется окружение, повторная авторизация не требуется.
        /// </summary>
        /// <returns>Интерфейс для взаимодействия с ВКонтакте.</returns>
        public static IVkSdk GetSame() =>
            Get(ReceiveMode.Same);
    }
}