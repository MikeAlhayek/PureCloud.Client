using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// PolicyAttribute
/// </summary>

public partial class PolicyAttribute : IEquatable<PolicyAttribute>
{
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    
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
        /// Enum Boolean for "BOOLEAN"
        /// </summary>
        [EnumMember(Value = "BOOLEAN")]
        Boolean,

        /// <summary>
        /// Enum Number for "NUMBER"
        /// </summary>
        [EnumMember(Value = "NUMBER")]
        Number,

        /// <summary>
        /// Enum String for "STRING"
        /// </summary>
        [EnumMember(Value = "STRING")]
        String,

        /// <summary>
        /// Enum StringList for "STRING_LIST"
        /// </summary>
        [EnumMember(Value = "STRING_LIST")]
        StringList,

        /// <summary>
        /// Enum Time for "TIME"
        /// </summary>
        [EnumMember(Value = "TIME")]
        Time,

        /// <summary>
        /// Enum RelativeTime for "RELATIVE_TIME"
        /// </summary>
        [EnumMember(Value = "RELATIVE_TIME")]
        RelativeTime,

        /// <summary>
        /// Enum TimeRange for "TIME_RANGE"
        /// </summary>
        [EnumMember(Value = "TIME_RANGE")]
        TimeRange,

        /// <summary>
        /// Enum DayRange for "DAY_RANGE"
        /// </summary>
        [EnumMember(Value = "DAY_RANGE")]
        DayRange,

        /// <summary>
        /// Enum IpAddress for "IP_ADDRESS"
        /// </summary>
        [EnumMember(Value = "IP_ADDRESS")]
        IpAddress,

        /// <summary>
        /// Enum IpCidr for "IP_CIDR"
        /// </summary>
        [EnumMember(Value = "IP_CIDR")]
        IpCidr
    }
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [JsonPropertyName("type")]
    public TypeEnum? Type { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="PolicyAttribute" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="Type">Type.</param>
    /// <param name="Description">Description.</param>
    /// <param name="FeatureToggle">FeatureToggle.</param>
    public PolicyAttribute(string Name = null, TypeEnum? Type = null, string Description = null, string FeatureToggle = null)
    {
        this.Name = Name;
        this.Type = Type;
        this.Description = Description;
        this.FeatureToggle = FeatureToggle;

    }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }





    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [JsonPropertyName("description")]
    public string Description { get; set; }



    /// <summary>
    /// Gets or Sets FeatureToggle
    /// </summary>
    [JsonPropertyName("featureToggle")]
    public string FeatureToggle { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class PolicyAttribute {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  FeatureToggle: ").Append(FeatureToggle).Append("\n");
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
        return Equals(obj as PolicyAttribute);
    }

    /// <summary>
    /// Returns true if PolicyAttribute instances are equal
    /// </summary>
    /// <param name="other">Instance of PolicyAttribute to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PolicyAttribute other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
            ) &&
            (
                FeatureToggle == other.FeatureToggle ||
                FeatureToggle != null &&
                FeatureToggle.Equals(other.FeatureToggle)
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
            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (FeatureToggle != null)
            {
                hash = hash * 59 + FeatureToggle.GetHashCode();
            }

            return hash;
        }
    }
}
