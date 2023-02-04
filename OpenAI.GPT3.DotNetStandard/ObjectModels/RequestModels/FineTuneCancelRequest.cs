using System.Text.Json.Serialization;

namespace OpenAI.GPT3.DotNetStandard.ObjectModels.RequestModels
{
    public record FineTuneCancelRequest
    {
        [JsonPropertyName("fine_tune_id")] public string FineTuneId { get; set; }
    }
}