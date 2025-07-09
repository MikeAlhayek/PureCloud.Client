using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ValidationErrorListing
{
    /// <summary>
    /// Gets or Sets Entities
    /// </summary>
    public IEnumerable<ValidationErrorResponse> Entities { get; set; }
}
