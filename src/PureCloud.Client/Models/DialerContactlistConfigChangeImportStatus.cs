using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class DialerContactlistConfigChangeImportStatus
{
    /// <summary>
    /// current status of the import
    /// </summary>
    /// <value>current status of the import</value>
    public DialerContactlistConfigChangeImportStatusImportStateEnum? ImportState { get; set; }

    /// <summary>
    /// total number of records to be imported
    /// </summary>
    /// <value>total number of records to be imported</value>
    public long? TotalRecords { get; set; }

    /// <summary>
    /// number of records finished importing
    /// </summary>
    /// <value>number of records finished importing</value>
    public long? CompletedRecords { get; set; }

    /// <summary>
    /// percentage of records finished importing
    /// </summary>
    /// <value>percentage of records finished importing</value>
    public long? PercentageComplete { get; set; }

    /// <summary>
    /// if the import has failed, the reason for the failure
    /// </summary>
    /// <value>if the import has failed, the reason for the failure</value>
    public string FailureReason { get; set; }

    /// <summary>
    /// The ids for target contact lists
    /// </summary>
    /// <value>The ids for target contact lists</value>
    public IEnumerable<string> TargetContactListIds { get; set; }

    /// <summary>
    /// The prefix used for target contact list names
    /// </summary>
    /// <value>The prefix used for target contact list names</value>
    public string ListNamePrefix { get; set; }

    /// <summary>
    /// Gets or Sets AdditionalProperties
    /// </summary>
    public Dictionary<string, object> AdditionalProperties { get; set; }
}
