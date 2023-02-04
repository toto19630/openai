using System.Threading.Tasks;
using OpenAI.GPT3.DotNetStandard.Extensions;
using OpenAI.GPT3.DotNetStandard.Interfaces;
using OpenAI.GPT3.DotNetStandard.ObjectModels.RequestModels;
using OpenAI.GPT3.DotNetStandard.ObjectModels.ResponseModels;

namespace OpenAI.GPT3.DotNetStandard.Managers
{
    public partial class OpenAIService : IModerationService
    {
        /// <inheritdoc />
        public async Task<CreateModerationResponse> CreateModeration(CreateModerationRequest createModerationRequest)
        {
            return await _httpClient.PostAndReadAsAsync<CreateModerationResponse>(_endpointProvider.ModerationCreate(), createModerationRequest);
        }

        public Task<CreateModerationResponse> CreateModeration(string input, string model = null)
        {
            return CreateModeration(new CreateModerationRequest()
            {
                Input = input,
                Model = model
            });
        }
    }
}