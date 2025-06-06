using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// RoutingActivityResponse
/// </summary>

public partial class RoutingActivityResponse : IEquatable<RoutingActivityResponse>
{
    /// <summary>
    /// Dimension that is used as an entityId
    /// </summary>
    /// <value>Dimension that is used as an entityId</value>
    
    public enum EntityIdDimensionEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Organizationpresenceid for "organizationPresenceId"
        /// </summary>
        [EnumMember(Value = "organizationPresenceId")]
        Organizationpresenceid,

        /// <summary>
        /// Enum Presencedate for "presenceDate"
        /// </summary>
        [EnumMember(Value = "presenceDate")]
        Presencedate,

        /// <summary>
        /// Enum Queueid for "queueId"
        /// </summary>
        [EnumMember(Value = "queueId")]
        Queueid,

        /// <summary>
        /// Enum Queuemembershipstatus for "queueMembershipStatus"
        /// </summary>
        [EnumMember(Value = "queueMembershipStatus")]
        Queuemembershipstatus,

        /// <summary>
        /// Enum Routingstatus for "routingStatus"
        /// </summary>
        [EnumMember(Value = "routingStatus")]
        Routingstatus,

        /// <summary>
        /// Enum Routingstatusdate for "routingStatusDate"
        /// </summary>
        [EnumMember(Value = "routingStatusDate")]
        Routingstatusdate,

        /// <summary>
        /// Enum Systempresence for "systemPresence"
        /// </summary>
        [EnumMember(Value = "systemPresence")]
        Systempresence,

        /// <summary>
        /// Enum Teamid for "teamId"
        /// </summary>
        [EnumMember(Value = "teamId")]
        Teamid,

        /// <summary>
        /// Enum Userid for "userId"
        /// </summary>
        [EnumMember(Value = "userId")]
        Userid
    }
    /// <summary>
    /// Dimension that is used as an entityId
    /// </summary>
    /// <value>Dimension that is used as an entityId</value>
    [JsonPropertyName("entityIdDimension")]
    public EntityIdDimensionEnum? EntityIdDimension { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="RoutingActivityResponse" /> class.
    /// </summary>
    /// <param name="Results">Query results.</param>
    /// <param name="EntityIdDimension">Dimension that is used as an entityId.</param>
    public RoutingActivityResponse(List<RoutingActivityData> Results = null, EntityIdDimensionEnum? EntityIdDimension = null)
    {
        this.Results = Results;
        this.EntityIdDimension = EntityIdDimension;

    }



    /// <summary>
    /// Query results
    /// </summary>
    /// <value>Query results</value>
    [JsonPropertyName("results")]
    public List<RoutingActivityData> Results { get; set; }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class RoutingActivityResponse {\n");

        sb.Append("  Results: ").Append(Results).Append("\n");
        sb.Append("  EntityIdDimension: ").Append(EntityIdDimension).Append("\n");
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
        return Equals(obj as RoutingActivityResponse);
    }

    /// <summary>
    /// Returns true if RoutingActivityResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of RoutingActivityResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(RoutingActivityResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Results == other.Results ||
                Results != null &&
                Results.SequenceEqual(other.Results)
            ) &&
            (
                EntityIdDimension == other.EntityIdDimension ||
                EntityIdDimension != null &&
                EntityIdDimension.Equals(other.EntityIdDimension)
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
            if (Results != null)
            {
                hash = hash * 59 + Results.GetHashCode();
            }

            if (EntityIdDimension != null)
            {
                hash = hash * 59 + EntityIdDimension.GetHashCode();
            }

            return hash;
        }
    }
}
