using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AdherenceExplanationJobReference
/// </summary>

public partial class AdherenceExplanationJobReference : IEquatable<AdherenceExplanationJobReference>
{
    /// <summary>
    /// The type of the adherence explanation job
    /// </summary>
    /// <value>The type of the adherence explanation job</value>
    
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
        /// Enum Addexplanation for "AddExplanation"
        /// </summary>
        [EnumMember(Value = "AddExplanation")]
        Addexplanation,

        /// <summary>
        /// Enum Updateexplanation for "UpdateExplanation"
        /// </summary>
        [EnumMember(Value = "UpdateExplanation")]
        Updateexplanation,

        /// <summary>
        /// Enum Queryagentexplanations for "QueryAgentExplanations"
        /// </summary>
        [EnumMember(Value = "QueryAgentExplanations")]
        Queryagentexplanations,

        /// <summary>
        /// Enum Querybuexplanations for "QueryBuExplanations"
        /// </summary>
        [EnumMember(Value = "QueryBuExplanations")]
        Querybuexplanations
    }
    /// <summary>
    /// The status of the adherence explanation job
    /// </summary>
    /// <value>The status of the adherence explanation job</value>
    
    public enum StatusEnum
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
    /// The type of the adherence explanation job
    /// </summary>
    /// <value>The type of the adherence explanation job</value>
    [JsonPropertyName("type")]
    public TypeEnum? Type { get; set; }
    /// <summary>
    /// The status of the adherence explanation job
    /// </summary>
    /// <value>The status of the adherence explanation job</value>
    [JsonPropertyName("status")]
    public StatusEnum? Status { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="AdherenceExplanationJobReference" /> class.
    /// </summary>
    /// <param name="Type">The type of the adherence explanation job.</param>
    /// <param name="Status">The status of the adherence explanation job.</param>
    public AdherenceExplanationJobReference(TypeEnum? Type = null, StatusEnum? Status = null)
    {
        this.Type = Type;
        this.Status = Status;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; private set; }







    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AdherenceExplanationJobReference {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
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
        return Equals(obj as AdherenceExplanationJobReference);
    }

    /// <summary>
    /// Returns true if AdherenceExplanationJobReference instances are equal
    /// </summary>
    /// <param name="other">Instance of AdherenceExplanationJobReference to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AdherenceExplanationJobReference other)
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
                Status == other.Status ||
                Status != null &&
                Status.Equals(other.Status)
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

            if (Status != null)
            {
                hash = hash * 59 + Status.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
