using CompanyName.ProjectName.BuildingBlocks.Common;
using System.Text.Json;

namespace CompanyName.ProjectName.BuilidingBlocks.Application.Exceptions
{
    public class InvalidRequestException : ApplicationExceptionBase
    {
        public List<string> Errors { get; }

        public InvalidRequestException(List<string> errors)
        {
            Errors = errors;
        }

        public override string GetDetails()
        {
            return JsonSerializer.Serialize(Errors);
        }
    }
}
