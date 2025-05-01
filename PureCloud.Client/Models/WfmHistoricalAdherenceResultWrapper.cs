using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WfmHistoricalAdherenceResultWrapper
/// </summary>
[DataContract]
public partial class WfmHistoricalAdherenceResultWrapper : IEquatable<WfmHistoricalAdherenceResultWrapper>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WfmHistoricalAdherenceResultWrapper" /> class.
    /// </summary>
    /// <param name="EntityId">The operation ID of the historical adherence query.</param>
    /// <param name="Data">The list of historical adherence query results.</param>
    /// <param name="LookupIdToSecondaryPresenceId">Map of secondary presence lookup ID to corresponding secondary presence ID.</param>
    public WfmHistoricalAdherenceResultWrapper(string EntityId = null, List<HistoricalAdherenceQueryResult> Data = null, Dictionary<string, string> LookupIdToSecondaryPresenceId = null)
    {
        this.EntityId = EntityId;
        this.Data = Data;
        this.LookupIdToSecondaryPresenceId = LookupIdToSecondaryPresenceId;

    }



    /// <summary>
    /// The operation ID of the historical adherence query
    /// </summary>
    /// <value>The operation ID of the historical adherence query</value>
    [DataMember(Name = "entityId", EmitDefaultValue = false)]
    public string EntityId { get; set; }



    /// <summary>
    /// The list of historical adherence query results
    /// </summary>
    /// <value>The list of historical adherence query results</value>
    [DataMember(Name = "data", EmitDefaultValue = false)]
    public List<HistoricalAdherenceQueryResult> Data { get; set; }



    /// <summary>
    /// Map of secondary presence lookup ID to corresponding secondary presence ID
    /// </summary>
    /// <value>Map of secondary presence lookup ID to corresponding secondary presence ID</value>
    [DataMember(Name = "lookupIdToSecondaryPresenceId", EmitDefaultValue = false)]
    public Dictionary<string, string> LookupIdToSecondaryPresenceId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WfmHistoricalAdherenceResultWrapper {\n");

        sb.Append("  EntityId: ").Append(EntityId).Append("\n");
        sb.Append("  Data: ").Append(Data).Append("\n");
        sb.Append("  LookupIdToSecondaryPresenceId: ").Append(LookupIdToSecondaryPresenceId).Append("\n");
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
        return Equals(obj as WfmHistoricalAdherenceResultWrapper);
    }

    /// <summary>
    /// Returns true if WfmHistoricalAdherenceResultWrapper instances are equal
    /// </summary>
    /// <param name="other">Instance of WfmHistoricalAdherenceResultWrapper to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WfmHistoricalAdherenceResultWrapper other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                EntityId == other.EntityId ||
                EntityId != null &&
                EntityId.Equals(other.EntityId)
            ) &&
            (
                Data == other.Data ||
                Data != null &&
                Data.SequenceEqual(other.Data)
            ) &&
            (
                LookupIdToSecondaryPresenceId == other.LookupIdToSecondaryPresenceId ||
                LookupIdToSecondaryPresenceId != null &&
                LookupIdToSecondaryPresenceId.SequenceEqual(other.LookupIdToSecondaryPresenceId)
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
            if (EntityId != null)
            {
                hash = hash * 59 + EntityId.GetHashCode();
            }

            if (Data != null)
            {
                hash = hash * 59 + Data.GetHashCode();
            }

            if (LookupIdToSecondaryPresenceId != null)
            {
                hash = hash * 59 + LookupIdToSecondaryPresenceId.GetHashCode();
            }

            return hash;
        }
    }
}
