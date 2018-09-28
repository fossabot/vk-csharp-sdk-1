using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Vk.CSharp.Sdk.Core.Components.Interfaces;
using Vk.CSharp.Sdk.Core.Enums;
using Vk.CSharp.Sdk.Core.Executors.Interfaces;
using Vk.CSharp.Sdk.Core.Extensions;
using Vk.CSharp.Sdk.Core.Models;
using Vk.CSharp.Sdk.Core.Services.Interfaces;
using Vk.CSharp.Sdk.Exceptions;

namespace Vk.CSharp.Sdk.Core.Executors
{
    internal class RequestExecutor<TResponse> : IRequestExecutor<TResponse>
    {
        private ITransformationService TransformationService { get; }
        private IBrowser Browser { get; }

        public RequestExecutor(ITransformationService transformationService, IBrowser browser)
        {
            TransformationService = transformationService;
            Browser = browser;
        }

        public async Task<TResponse> ExecuteAsync(Request request)
        {
            var json = await Browser
                .GetResponseAsync(request.Value)
                .ConfigureAwait(false);

            var response = ExecuteInternal(json);

            if (!EqualityComparer<TResponse>.Default.Equals(response.Data, default(TResponse)))
                return response.Data;

            throw new VkApiException(
                CreateExceptionMessage(response, request),
                response.Error?.ErrorCode ??
                throw new ResponseException("Ошибка обработки ответа. Ответ не соответствует шаблону.")
            );
        }

        private Response<TResponse> ExecuteInternal(string json)
        {
            try
            {
                return TransformationService.Deserialize<Response<TResponse>>(json);
            }
            catch (Exception ex)
            {
                throw new DeserializeException(
                    $"Ошибка десериализации ответа. Тип ответа: {typeof(TResponse).Name}.", ex);
            }
        }

        private static string CreateExceptionMessage(Response<TResponse> response, Request request)
        {
            var errorEnum = (Error) (
                response.Error?.ErrorCode ??
                throw new ResponseException("Ошибка обработки ответа. Ответ не соответствует шаблону.")
            );

            var errorCode = response.Error.ErrorCode;

            return
                $"Код ошибки: {errorCode}. " +
                $"Описание ошибки: {errorEnum.GetDescription()}. " +
                $"Имя метода: {request.MethodName}.";
        }
    }
}