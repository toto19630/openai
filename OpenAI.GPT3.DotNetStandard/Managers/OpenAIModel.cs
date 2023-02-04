using System.Threading.Tasks;
using OpenAI.GPT3.DotNetStandard.Extensions;
using OpenAI.GPT3.DotNetStandard.Interfaces;
using OpenAI.GPT3.DotNetStandard.ObjectModels.ResponseModels.ModelResponseModels;

namespace OpenAI.GPT3.DotNetStandard.Managers;

public partial class OpenAIService : IModelService
{
    public async Task<ModelListResponse> ListModel()
    {
        return await _httpClient.GetFromJsonAsync<ModelListResponse>(_endpointProvider.ModelsList());
    }

    public async Task<ModelRetrieveResponse> RetrieveModel(string model)
    {
        return await _httpClient.GetFromJsonAsync<ModelRetrieveResponse>(_endpointProvider.ModelRetrieve(model));
    }
}