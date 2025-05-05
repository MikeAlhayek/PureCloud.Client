using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// RuleSetDiagnostic
/// </summary>

public partial class RuleSetDiagnostic : IEquatable<RuleSetDiagnostic>
{
    /// <summary>
    /// Gets or Sets Warnings
    /// </summary>
    
    public enum WarningsEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum WrapupCodeNotInQueue for "WRAPUP_CODE_NOT_IN_QUEUE"
        /// </summary>
        [EnumMember(Value = "WRAPUP_CODE_NOT_IN_QUEUE")]
        WrapupCodeNotInQueue,

        /// <summary>
        /// Enum ContactAttributeNotInContactList for "CONTACT_ATTRIBUTE_NOT_IN_CONTACT_LIST"
        /// </summary>
        [EnumMember(Value = "CONTACT_ATTRIBUTE_NOT_IN_CONTACT_LIST")]
        ContactAttributeNotInContactList,

        /// <summary>
        /// Enum NoDncListForAppend for "NO_DNC_LIST_FOR_APPEND"
        /// </summary>
        [EnumMember(Value = "NO_DNC_LIST_FOR_APPEND")]
        NoDncListForAppend,

        /// <summary>
        /// Enum PhoneConditionsWithMulticolumnPreview for "PHONE_CONDITIONS_WITH_MULTICOLUMN_PREVIEW"
        /// </summary>
        [EnumMember(Value = "PHONE_CONDITIONS_WITH_MULTICOLUMN_PREVIEW")]
        PhoneConditionsWithMulticolumnPreview
    }
    /// <summary>
    /// Initializes a new instance of the <see cref="RuleSetDiagnostic" /> class.
    /// </summary>
    public RuleSetDiagnostic()
    {

    }



    /// <summary>
    /// A campaign rule set
    /// </summary>
    /// <value>A campaign rule set</value>
    [JsonPropertyName("ruleSet")]
    public DomainEntityRef RuleSet { get; private set; }



    /// <summary>
    /// Diagnostic warnings for the rule set
    /// </summary>
    /// <value>Diagnostic warnings for the rule set</value>
    [JsonPropertyName("warnings")]
    public List<WarningsEnum> Warnings { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class RuleSetDiagnostic {\n");

        sb.Append("  RuleSet: ").Append(RuleSet).Append("\n");
        sb.Append("  Warnings: ").Append(Warnings).Append("\n");
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
        return Equals(obj as RuleSetDiagnostic);
    }

    /// <summary>
    /// Returns true if RuleSetDiagnostic instances are equal
    /// </summary>
    /// <param name="other">Instance of RuleSetDiagnostic to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(RuleSetDiagnostic other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                RuleSet == other.RuleSet ||
                RuleSet != null &&
                RuleSet.Equals(other.RuleSet)
            ) &&
            (
                Warnings == other.Warnings ||
                Warnings != null &&
                Warnings.SequenceEqual(other.Warnings)
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
            if (RuleSet != null)
            {
                hash = hash * 59 + RuleSet.GetHashCode();
            }

            if (Warnings != null)
            {
                hash = hash * 59 + Warnings.GetHashCode();
            }

            return hash;
        }
    }
}
