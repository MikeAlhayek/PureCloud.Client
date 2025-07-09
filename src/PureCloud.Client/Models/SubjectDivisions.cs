using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class SubjectDivisions
{
    /// <summary>
    /// A collection of subject IDs to associate with the given divisions
    /// </summary>
    /// <value>A collection of subject IDs to associate with the given divisions</value>
    public IEnumerable<string> SubjectIds { get; set; }

    /// <summary>
    /// A collection of division IDs to associate with the given subjects
    /// </summary>
    /// <value>A collection of division IDs to associate with the given subjects</value>
    public IEnumerable<string> DivisionIds { get; set; }
}
