using System.Threading.Tasks;
using OpenAI.GPT3.DotNetStandard.ObjectModels;
using OpenAI.GPT3.DotNetStandard.ObjectModels.RequestModels;
using OpenAI.GPT3.DotNetStandard.ObjectModels.ResponseModels;

namespace OpenAI.GPT3.DotNetStandard.Interfaces;

/// <summary>
///     Given a prompt and an instruction, the model will return an edited version of the prompt.
/// </summary>
public interface IEditService
{
    /// <summary>
    ///     Creates a new edit for the provided input, instruction, and parameters
    /// </summary>
    /// <param name="editCreate"></param>
    /// <param name="engineId">The ID of the engine to use for this request</param>
    /// <returns></returns>
    Task<EditCreateResponse> CreateEdit(EditCreateRequest editCreate, string? engineId = null);

    /// <summary>
    ///     Creates a new edit for the provided input, instruction, and parameters
    /// </summary>
    /// <param name="editCreate"></param>
    /// <param name="engineId">The ID of the engine to use for this request</param>
    /// <returns></returns>
    Task<EditCreateResponse> Edit(EditCreateRequest editCreate, Models.Model engineId);
}