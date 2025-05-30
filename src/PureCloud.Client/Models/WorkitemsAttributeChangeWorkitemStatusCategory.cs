using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WorkitemsAttributeChangeWorkitemStatusCategory
/// </summary>

public partial class WorkitemsAttributeChangeWorkitemStatusCategory : IEquatable<WorkitemsAttributeChangeWorkitemStatusCategory>
{
    /// <summary>
    /// New property value
    /// </summary>
    /// <value>New property value</value>
    
    public enum NewValueEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Open for "Open"
        /// </summary>
        [EnumMember(Value = "Open")]
        Open,

        /// <summary>
        /// Enum Inprogress for "InProgress"
        /// </summary>
        [EnumMember(Value = "InProgress")]
        Inprogress,

        /// <summary>
        /// Enum Waiting for "Waiting"
        /// </summary>
        [EnumMember(Value = "Waiting")]
        Waiting,

        /// <summary>
        /// Enum Closed for "Closed"
        /// </summary>
        [EnumMember(Value = "Closed")]
        Closed,

        /// <summary>
        /// Enum Unknown for "Unknown"
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown
    }
    /// <summary>
    /// Old property value
    /// </summary>
    /// <value>Old property value</value>
    
    public enum OldValueEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Open for "Open"
        /// </summary>
        [EnumMember(Value = "Open")]
        Open,

        /// <summary>
        /// Enum Inprogress for "InProgress"
        /// </summary>
        [EnumMember(Value = "InProgress")]
        Inprogress,

        /// <summary>
        /// Enum Waiting for "Waiting"
        /// </summary>
        [EnumMember(Value = "Waiting")]
        Waiting,

        /// <summary>
        /// Enum Closed for "Closed"
        /// </summary>
        [EnumMember(Value = "Closed")]
        Closed,

        /// <summary>
        /// Enum Unknown for "Unknown"
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown
    }
    /// <summary>
    /// New property value
    /// </summary>
    /// <value>New property value</value>
    [JsonPropertyName("newValue")]
    public NewValueEnum? NewValue { get; set; }
    /// <summary>
    /// Old property value
    /// </summary>
    /// <value>Old property value</value>
    [JsonPropertyName("oldValue")]
    public OldValueEnum? OldValue { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="WorkitemsAttributeChangeWorkitemStatusCategory" /> class.
    /// </summary>
    /// <param name="NewValue">New property value.</param>
    /// <param name="OldValue">Old property value.</param>
    public WorkitemsAttributeChangeWorkitemStatusCategory(NewValueEnum? NewValue = null, OldValueEnum? OldValue = null)
    {
        this.NewValue = NewValue;
        this.OldValue = OldValue;

    }






    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WorkitemsAttributeChangeWorkitemStatusCategory {\n");

        sb.Append("  NewValue: ").Append(NewValue).Append("\n");
        sb.Append("  OldValue: ").Append(OldValue).Append("\n");
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
        return Equals(obj as WorkitemsAttributeChangeWorkitemStatusCategory);
    }

    /// <summary>
    /// Returns true if WorkitemsAttributeChangeWorkitemStatusCategory instances are equal
    /// </summary>
    /// <param name="other">Instance of WorkitemsAttributeChangeWorkitemStatusCategory to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WorkitemsAttributeChangeWorkitemStatusCategory other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                NewValue == other.NewValue ||
                NewValue != null &&
                NewValue.Equals(other.NewValue)
            ) &&
            (
                OldValue == other.OldValue ||
                OldValue != null &&
                OldValue.Equals(other.OldValue)
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
            if (NewValue != null)
            {
                hash = hash * 59 + NewValue.GetHashCode();
            }

            if (OldValue != null)
            {
                hash = hash * 59 + OldValue.GetHashCode();
            }

            return hash;
        }
    }
}
