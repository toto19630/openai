using System.Collections.Generic;
using System.Text.Json.Serialization;
using OpenAI.GPT3.DotNetStandard.ObjectModels.SharedModels;

namespace OpenAI.GPT3.DotNetStandard.ObjectModels.ResponseModels.FineTuneResponseModels;

public record FineTuneListEventsResponse : BaseResponse
{
    [JsonPropertyName("data")] public List<EventResponse> Data { get; set; }
}