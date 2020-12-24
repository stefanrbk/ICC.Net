using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICC.Net
{
    public record ValidationResult(ImmutableArray<(ValidateStatus Status, string Message)> Values)
    {
        public ValidationResult Add(ValidateStatus status, string sigName, string message = "") =>
            this with 
            { 
                Values = Values.Add((status, status switch
                {
                    ValidateStatus.CriticalError => IccUtil.ValidateCreticalErrorMessage,
                    ValidateStatus.NonCompliant => IccUtil.ValidateNonComplaiantMessage,
                    ValidateStatus.Warning => IccUtil.ValidateWarningMessage,
                    _ => "",
                } + sigName + message)) 
            };
    }
}
