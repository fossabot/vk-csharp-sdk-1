namespace Vk.CSharp.Sdk.Models
{
    /// <summary>
    /// Данные для атворизации.
    /// </summary>
    public class AuthorizationData
    {
        /// <summary>
        /// Логин.
        /// </summary>
        public string Login { get; set; }

        /// <summary>
        /// Пароль.
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Идентификатор приложения.
        /// </summary>
        public long ApplicationId { get; set; }

        /// <summary>
        /// Ключ доступа.
        /// </summary>
        public string AccessToken { get; set; }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="AuthorizationData" />.
        /// </summary>
        /// <param name="login">Логин.</param>
        /// <param name="password">Пароль.</param>
        public AuthorizationData(string login, string password)
        {
            Login = login;
            Password = password;
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="AuthorizationData" />.
        /// </summary>
        /// <param name="accessToken">Ключ доступа.</param>
        public AuthorizationData(string accessToken)
        {
            AccessToken = accessToken;
        }
    }
}