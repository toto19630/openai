using System.Threading.Tasks;
using OpenAI.GPT3.DotNetStandard.ObjectModels.RequestModels;
using OpenAI.GPT3.DotNetStandard.ObjectModels.ResponseModels;

namespace OpenAI.GPT3.DotNetStandard.Interfaces;

/// <summary>
///     Creates an embedding vector representing the input text.
/// </summary>
public interface IEmbeddingService
{
    /// <summary>
    ///     Creates a new embedding for the provided input and parameters.
    /// </summary>
    /// <param name="createEmbeddingModel"></param>
    /// <returns></returns>
    Task<EmbeddingCreateResponse> CreateEmbedding(EmbeddingCreateRequest createEmbeddingModel);
}