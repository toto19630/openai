using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OpenAI.GPT3.DotNetStandard.Interfaces
{
    public interface IModelValidate
    {
        IEnumerable<ValidationResult> Validate();
    }
}