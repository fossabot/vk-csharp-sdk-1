namespace Vk.CSharp.Sdk.Core.Models
{
    internal class RequestData<TParameters> where TParameters : class
    {
        public TParameters Parameters { get; set; }

        public string MethodName { get; set; }

        public string AccessToken { get; set; }

        public RequestData(TParameters parameters, string methodName, string accessToken)
        {
            Parameters = parameters;
            MethodName = methodName;
            AccessToken = accessToken;
        }
    }
}