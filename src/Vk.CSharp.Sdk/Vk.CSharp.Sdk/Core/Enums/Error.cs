using Vk.CSharp.Sdk.Core.Attributes.Enums;

namespace Vk.CSharp.Sdk.Core.Enums
{
    // Ссылка: https://vk.com/dev/errors

    internal enum Error
    {
        [EnumDescription("Произошла неизвестная ошибка.")]
        E1 = 1,

        [EnumDescription("Приложение выключено.")]
        E2 = 2,

        [EnumDescription("Передан неизвестный метод.")]
        E3 = 3,

        [EnumDescription("Неверная подпись.")]
        E4 = 4,

        [EnumDescription("Авторизация пользователя не удалась.")]
        E5 = 5,

        [EnumDescription("Слишком много запросов в секунду.")]
        E6 = 6,

        [EnumDescription("Нет прав для выполнения этого действия.")]
        E7 = 7,

        [EnumDescription("Неверный запрос.")]
        E8 = 8,

        [EnumDescription("Слишком много однотипных действий.")]
        E9 = 9,

        [EnumDescription("Произошла внутренняя ошибка сервера.")]
        E10 = 10,

        [EnumDescription("В тестовом режиме приложение должно быть выключено (пользователь залогинен).")]
        E11 = 11,

        [EnumDescription("Требуется ввод кода с картинки (Captcha).")]
        E12 = 14,

        [EnumDescription("Доступ запрещён.")]
        E13 = 15,

        [EnumDescription("Требуется выполнение запросов по протоколу HTTPS.")]
        E14 = 16,

        [EnumDescription("Требуется валидация пользователя.")]
        E15 = 17,

        [EnumDescription("Страница удалена или заблокирована.")]
        E16 = 18,

        [EnumDescription("Данное действие запрещено для не Standalone приложений.")]
        E17 = 20,

        [EnumDescription("Данное действие разрешено только для Standalone и Open API приложений.")]
        E18 = 21,

        [EnumDescription("Метод был выключен.")]
        E19 = 23,

        [EnumDescription("Требуется подтверждение со стороны пользователя.")]
        E20 = 24,

        [EnumDescription("Ключ доступа сообщества недействителен.")]
        E21 = 27,

        [EnumDescription("Ключ доступа приложения недействителен.")]
        E22 = 28,

        [EnumDescription("Достигнут количественный лимит на вызов метода.")]
        E23 = 29,

        [EnumDescription("Один из необходимых параметров был не передан или неверен.")]
        E24 = 100,

        [EnumDescription("Неверный идентификатор приложения.")]
        E25 = 101,

        [EnumDescription("Неверный идентификатор пользователя.")]
        E26 = 113,

        [EnumDescription("Неверный TimeStamp.")]
        E27 = 150,

        [EnumDescription("Доступ к альбому запрещён.")]
        E28 = 200,

        [EnumDescription("Доступ к аудио запрещён.")]
        E29 = 201,

        [EnumDescription("Доступ к группе запрещён.")]
        E30 = 203,

        [EnumDescription("Альбом переполнен.")]
        E31 = 300,

        [EnumDescription("Действие запрещено. Вы должны включить переводы голосов в настройках приложения.")]
        E32 = 500,

        [EnumDescription("Нет прав на выполнение данных операций с рекламным кабинетом.")]
        E33 = 600,

        [EnumDescription("Произошла ошибка при работе с рекламным кабинетом.")]
        E34 = 603,

        [EnumDescription("Доступ к меню запрещен.")]
        E35 = 148,

        [EnumDescription("Этот профиль закрыт.")]
        E36 = 30
    }
}