using System.Threading.Tasks;
using OpenAI.GPT3.DotNetStandard.Extensions;
using OpenAI.GPT3.DotNetStandard.Interfaces;
using OpenAI.GPT3.DotNetStandard.ObjectModels;
using OpenAI.GPT3.DotNetStandard.ObjectModels.RequestModels;
using OpenAI.GPT3.DotNetStandard.ObjectModels.ResponseModels;

namespace OpenAI.GPT3.DotNetStandard.Managers;

public partial class OpenAIService : IEditService
{
    public async Task<EditCreateResponse> CreateEdit(EditCreateRequest editCreate, string? modelId = null)
    {
        editCreate.ProcessModelId(modelId, _defaultModelId);
        return await _httpClient.PostAndReadAsAsync<EditCreateResponse>(_endpointProvider.EditCreate(), editCreate);
    }

    Task<EditCreateResponse> IEditService.Edit(EditCreateRequest editCreate, Models.Model engineId)
    {
        return CreateEdit(editCreate, engineId.EnumToString());
    }
}