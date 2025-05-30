using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// HistoricalImportDeleteFilesJobResponse
/// </summary>

public partial class HistoricalImportDeleteFilesJobResponse : IEquatable<HistoricalImportDeleteFilesJobResponse>
{
    /// <summary>
    /// Property denoting the state of the remove request
    /// </summary>
    /// <value>Property denoting the state of the remove request</value>
    
    public enum StateEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Processing for "Processing"
        /// </summary>
        [EnumMember(Value = "Processing")]
        Processing,

        /// <summary>
        /// Enum Complete for "Complete"
        /// </summary>
        [EnumMember(Value = "Complete")]
        Complete,

        /// <summary>
        /// Enum Error for "Error"
        /// </summary>
        [EnumMember(Value = "Error")]
        Error
    }
    /// <summary>
    /// Property denoting the state of the remove request
    /// </summary>
    /// <value>Property denoting the state of the remove request</value>
    [JsonPropertyName("state")]
    public StateEnum? State { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="HistoricalImportDeleteFilesJobResponse" /> class.
    /// </summary>
    /// <param name="State">Property denoting the state of the remove request.</param>
    /// <param name="Entities">The request entities that got deleted.</param>
    /// <param name="DisallowedEntities">The request entities that were disallowed to be deleted.</param>
    public HistoricalImportDeleteFilesJobResponse(StateEnum? State = null, List<HistoricalDataDeleteEntity> Entities = null, List<HistoricalDataDisallowedDeleteEntity> DisallowedEntities = null)
    {
        this.State = State;
        this.Entities = Entities;
        this.DisallowedEntities = DisallowedEntities;

    }



    /// <summary>
    /// The Job Id Request
    /// </summary>
    /// <value>The Job Id Request</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }





    /// <summary>
    /// The request entities that got deleted
    /// </summary>
    /// <value>The request entities that got deleted</value>
    [JsonPropertyName("entities")]
    public List<HistoricalDataDeleteEntity> Entities { get; set; }



    /// <summary>
    /// The request entities that were disallowed to be deleted
    /// </summary>
    /// <value>The request entities that were disallowed to be deleted</value>
    [JsonPropertyName("disallowedEntities")]
    public List<HistoricalDataDisallowedDeleteEntity> DisallowedEntities { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class HistoricalImportDeleteFilesJobResponse {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  State: ").Append(State).Append("\n");
        sb.Append("  Entities: ").Append(Entities).Append("\n");
        sb.Append("  DisallowedEntities: ").Append(DisallowedEntities).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }


    /// <summary>
    /// Returns true if objects are equal
    /// </summary>
    /// <param name="obj">Object to be compared</param>
    /// <returns>Boolean</returns>
    public override bool Equals(object obj)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        return Equals(obj as HistoricalImportDeleteFilesJobResponse);
    }

    /// <summary>
    /// Returns true if HistoricalImportDeleteFilesJobResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of HistoricalImportDeleteFilesJobResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(HistoricalImportDeleteFilesJobResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                State == other.State ||
                State != null &&
                State.Equals(other.State)
            ) &&
            (
                Entities == other.Entities ||
                Entities != null &&
                Entities.SequenceEqual(other.Entities)
            ) &&
            (
                DisallowedEntities == other.DisallowedEntities ||
                DisallowedEntities != null &&
                DisallowedEntities.SequenceEqual(other.DisallowedEntities)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
            );
    }

    /// <summary>
    /// Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
    public override int GetHashCode()
    {
        // credit: http://stackoverflow.com/a/263416/677735
        unchecked // Overflow is fine, just wrap
        {
            int hash = 41;
            // Suitable nullity checks etc, of course :)
            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (State != null)
            {
                hash = hash * 59 + State.GetHashCode();
            }

            if (Entities != null)
            {
                hash = hash * 59 + Entities.GetHashCode();
            }

            if (DisallowedEntities != null)
            {
                hash = hash * 59 + DisallowedEntities.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
