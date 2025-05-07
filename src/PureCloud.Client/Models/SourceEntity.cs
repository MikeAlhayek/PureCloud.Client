using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// SourceEntity
/// </summary>

public partial class SourceEntity : IEquatable<SourceEntity>
{
    /// <summary>
    /// The type of the source entity
    /// </summary>
    /// <value>The type of the source entity</value>
    
    public enum TypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Thankyou for "ThankYou"
        /// </summary>
        [EnumMember(Value = "ThankYou")]
        Thankyou,

        /// <summary>
        /// Enum Congratulations for "Congratulations"
        /// </summary>
        [EnumMember(Value = "Congratulations")]
        Congratulations,

        /// <summary>
        /// Enum Highperformance for "HighPerformance"
        /// </summary>
        [EnumMember(Value = "HighPerformance")]
        Highperformance,

        /// <summary>
        /// Enum Companyvalues for "CompanyValues"
        /// </summary>
        [EnumMember(Value = "CompanyValues")]
        Companyvalues,

        /// <summary>
        /// Enum Competition for "Competition"
        /// </summary>
        [EnumMember(Value = "Competition")]
        Competition,

        /// <summary>
        /// Enum Race for "Race"
        /// </summary>
        [EnumMember(Value = "Race")]
        Race,

        /// <summary>
        /// Enum Raffle for "Raffle"
        /// </summary>
        [EnumMember(Value = "Raffle")]
        Raffle,

        /// <summary>
        /// Enum Teamgoal for "TeamGoal"
        /// </summary>
        [EnumMember(Value = "TeamGoal")]
        Teamgoal
    }
    /// <summary>
    /// The type of the source entity
    /// </summary>
    /// <value>The type of the source entity</value>
    [JsonPropertyName("type")]
    public TypeEnum? Type { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="SourceEntity" /> class.
    /// </summary>
    /// <param name="Type">The type of the source entity.</param>
    /// <param name="ContestCompleteData">The contest data - Only supplied when celebration is of type ContestComplete.</param>
    public SourceEntity(TypeEnum? Type = null, ContestCompleteData ContestCompleteData = null)
    {
        this.Type = Type;
        this.ContestCompleteData = ContestCompleteData;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }





    /// <summary>
    /// The contest data - Only supplied when celebration is of type ContestComplete
    /// </summary>
    /// <value>The contest data - Only supplied when celebration is of type ContestComplete</value>
    [JsonPropertyName("contestCompleteData")]
    public ContestCompleteData ContestCompleteData { get; set; }



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
        sb.Append("class SourceEntity {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  ContestCompleteData: ").Append(ContestCompleteData).Append("\n");
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
        return Equals(obj as SourceEntity);
    }

    /// <summary>
    /// Returns true if SourceEntity instances are equal
    /// </summary>
    /// <param name="other">Instance of SourceEntity to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SourceEntity other)
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
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                ContestCompleteData == other.ContestCompleteData ||
                ContestCompleteData != null &&
                ContestCompleteData.Equals(other.ContestCompleteData)
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

            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (ContestCompleteData != null)
            {
                hash = hash * 59 + ContestCompleteData.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
