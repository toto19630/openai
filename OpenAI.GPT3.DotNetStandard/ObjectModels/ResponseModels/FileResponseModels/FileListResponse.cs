using System.Collections.Generic;
using System.Text.Json.Serialization;
using OpenAI.GPT3.DotNetStandard.ObjectModels.SharedModels;

namespace OpenAI.GPT3.DotNetStandard.ObjectModels.ResponseModels.FileResponseModels
{
    public record FileListResponse : BaseResponse
    {
        [JsonPropertyName("data")] public List<FileResponse> Data { get; set; }
    }
}