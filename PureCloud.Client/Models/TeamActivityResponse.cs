using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// TeamActivityResponse
/// </summary>
[DataContract]
public partial class TeamActivityResponse : IEquatable<TeamActivityResponse>
{
    /// <summary>
    /// Dimension that is used as an entityId
    /// </summary>
    /// <value>Dimension that is used as an entityId</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
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
    [DataMember(Name = "entityIdDimension", EmitDefaultValue = false)]
    public EntityIdDimensionEnum? EntityIdDimension { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="TeamActivityResponse" /> class.
    /// </summary>
    /// <param name="Results">Query results.</param>
    /// <param name="EntityIdDimension">Dimension that is used as an entityId.</param>
    public TeamActivityResponse(List<TeamActivityData> Results = null, EntityIdDimensionEnum? EntityIdDimension = null)
    {
        this.Results = Results;
        this.EntityIdDimension = EntityIdDimension;

    }



    /// <summary>
    /// Query results
    /// </summary>
    /// <value>Query results</value>
    [DataMember(Name = "results", EmitDefaultValue = false)]
    public List<TeamActivityData> Results { get; set; }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TeamActivityResponse {\n");

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
        return this.Equals(obj as TeamActivityResponse);
    }

    /// <summary>
    /// Returns true if TeamActivityResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of TeamActivityResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TeamActivityResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.Results == other.Results ||
                this.Results != null &&
                this.Results.SequenceEqual(other.Results)
            ) &&
            (
                this.EntityIdDimension == other.EntityIdDimension ||
                this.EntityIdDimension != null &&
                this.EntityIdDimension.Equals(other.EntityIdDimension)
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
            if (this.Results != null)
            {
                hash = hash * 59 + this.Results.GetHashCode();
            }

            if (this.EntityIdDimension != null)
            {
                hash = hash * 59 + this.EntityIdDimension.GetHashCode();
            }

            return hash;
        }
    }
}
