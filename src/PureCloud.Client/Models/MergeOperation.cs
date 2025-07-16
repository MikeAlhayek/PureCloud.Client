using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class MergeOperation
{
    /// <summary>
    /// The source contact for the merge operation
    /// </summary>
    /// <value>The source contact for the merge operation</value>
    public AddressableEntityRef SourceContact { get; set; }

    /// <summary>
    /// The target contact for the merge operation
    /// </summary>
    /// <value>The target contact for the merge operation</value>
    public AddressableEntityRef TargetContact { get; set; }

    /// <summary>
    /// The contact created as a result of the merge operation
    /// </summary>
    /// <value>The contact created as a result of the merge operation</value>
    public AddressableEntityRef ResultingContact { get; set; }
}
