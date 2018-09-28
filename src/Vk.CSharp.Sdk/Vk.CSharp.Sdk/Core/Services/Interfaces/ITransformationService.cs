namespace Vk.CSharp.Sdk.Core.Services.Interfaces
{
    internal interface ITransformationService
    {
        TObject Deserialize<TObject>(string json);

        string Serialize<TObject>(TObject @object);
    }
}