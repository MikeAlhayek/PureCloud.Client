using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ExternalOrganizationIdentifierClaimRequest
/// </summary>

public partial class ExternalOrganizationIdentifierClaimRequest : IEquatable<ExternalOrganizationIdentifierClaimRequest>
{
    /// <summary>
    /// The operation to perform claim/release
    /// </summary>
    /// <value>The operation to perform claim/release</value>
    
    public enum OperationEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Claim for "Claim"
        /// </summary>
        [EnumMember(Value = "Claim")]
        Claim,

        /// <summary>
        /// Enum Release for "Release"
        /// </summary>
        [EnumMember(Value = "Release")]
        Release
    }
    /// <summary>
    /// The operation to perform claim/release
    /// </summary>
    /// <value>The operation to perform claim/release</value>
    [JsonPropertyName("operation")]
    public OperationEnum? Operation { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="ExternalOrganizationIdentifierClaimRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ExternalOrganizationIdentifierClaimRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ExternalOrganizationIdentifierClaimRequest" /> class.
    /// </summary>
    /// <param name="Operation">The operation to perform claim/release (required).</param>
    /// <param name="Identifier">The identifier that should be claimed/released from an external org (required).</param>
    public ExternalOrganizationIdentifierClaimRequest(OperationEnum? Operation = null, ExternalOrganizationIdentifier Identifier = null)
    {
        this.Operation = Operation;
        this.Identifier = Identifier;

    }





    /// <summary>
    /// The identifier that should be claimed/released from an external org
    /// </summary>
    /// <value>The identifier that should be claimed/released from an external org</value>
    [JsonPropertyName("identifier")]
    public ExternalOrganizationIdentifier Identifier { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ExternalOrganizationIdentifierClaimRequest {\n");

        sb.Append("  Operation: ").Append(Operation).Append("\n");
        sb.Append("  Identifier: ").Append(Identifier).Append("\n");
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
        return Equals(obj as ExternalOrganizationIdentifierClaimRequest);
    }

    /// <summary>
    /// Returns true if ExternalOrganizationIdentifierClaimRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of ExternalOrganizationIdentifierClaimRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ExternalOrganizationIdentifierClaimRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Operation == other.Operation ||
                Operation != null &&
                Operation.Equals(other.Operation)
            ) &&
            (
                Identifier == other.Identifier ||
                Identifier != null &&
                Identifier.Equals(other.Identifier)
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
            if (Operation != null)
            {
                hash = hash * 59 + Operation.GetHashCode();
            }

            if (Identifier != null)
            {
                hash = hash * 59 + Identifier.GetHashCode();
            }

            return hash;
        }
    }
}
