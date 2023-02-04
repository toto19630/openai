using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OpenAI.GPT3.DotNetStandard.ObjectModels.ResponseModels.ModelResponseModels
{
    public record ModelListResponse : BaseResponse
    {
        [JsonPropertyName("data")] public List<ModelResponse> Models { get; set; }
    }
}