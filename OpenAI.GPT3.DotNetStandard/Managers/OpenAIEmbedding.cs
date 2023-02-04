using System.Threading.Tasks;
using OpenAI.GPT3.DotNetStandard.Extensions;
using OpenAI.GPT3.DotNetStandard.Interfaces;
using OpenAI.GPT3.DotNetStandard.ObjectModels.RequestModels;
using OpenAI.GPT3.DotNetStandard.ObjectModels.ResponseModels;

namespace OpenAI.GPT3.DotNetStandard.Managers;

public partial class OpenAIService : IEmbeddingService
{
    public async Task<EmbeddingCreateResponse> CreateEmbedding(EmbeddingCreateRequest createEmbeddingRequest)
    {
        return await _httpClient.PostAndReadAsAsync<EmbeddingCreateResponse>(_endpointProvider.EmbeddingCreate(), createEmbeddingRequest);
    }
}