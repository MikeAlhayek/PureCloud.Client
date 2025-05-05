using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// OutboundMessagingWhatsappCampaignConfigChangeContactSort
/// </summary>

public partial class OutboundMessagingWhatsappCampaignConfigChangeContactSort : IEquatable<OutboundMessagingWhatsappCampaignConfigChangeContactSort>
{
    /// <summary>
    /// Gets or Sets Direction
    /// </summary>
    
    public enum DirectionEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Asc for "ASC"
        /// </summary>
        [EnumMember(Value = "ASC")]
        Asc,

        /// <summary>
        /// Enum Desc for "DESC"
        /// </summary>
        [EnumMember(Value = "DESC")]
        Desc
    }
    /// <summary>
    /// Gets or Sets Direction
    /// </summary>
    [JsonPropertyName("direction")]
    public DirectionEnum? Direction { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="OutboundMessagingWhatsappCampaignConfigChangeContactSort" /> class.
    /// </summary>
    /// <param name="FieldName">FieldName.</param>
    /// <param name="Direction">Direction.</param>
    /// <param name="Numeric">Whether that column contains numeric data.</param>
    /// <param name="AdditionalProperties">AdditionalProperties.</param>
    public OutboundMessagingWhatsappCampaignConfigChangeContactSort(string FieldName = null, DirectionEnum? Direction = null, bool? Numeric = null, Dictionary<string, object> AdditionalProperties = null)
    {
        this.FieldName = FieldName;
        this.Direction = Direction;
        this.Numeric = Numeric;
        this.AdditionalProperties = AdditionalProperties;

    }



    /// <summary>
    /// Gets or Sets FieldName
    /// </summary>
    [JsonPropertyName("fieldName")]
    public string FieldName { get; set; }





    /// <summary>
    /// Whether that column contains numeric data
    /// </summary>
    /// <value>Whether that column contains numeric data</value>
    [JsonPropertyName("numeric")]
    public bool? Numeric { get; set; }



    /// <summary>
    /// Gets or Sets AdditionalProperties
    /// </summary>
    [JsonPropertyName("additionalProperties")]
    public Dictionary<string, object> AdditionalProperties { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class OutboundMessagingWhatsappCampaignConfigChangeContactSort {\n");

        sb.Append("  FieldName: ").Append(FieldName).Append("\n");
        sb.Append("  Direction: ").Append(Direction).Append("\n");
        sb.Append("  Numeric: ").Append(Numeric).Append("\n");
        sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
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
        return Equals(obj as OutboundMessagingWhatsappCampaignConfigChangeContactSort);
    }

    /// <summary>
    /// Returns true if OutboundMessagingWhatsappCampaignConfigChangeContactSort instances are equal
    /// </summary>
    /// <param name="other">Instance of OutboundMessagingWhatsappCampaignConfigChangeContactSort to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(OutboundMessagingWhatsappCampaignConfigChangeContactSort other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                FieldName == other.FieldName ||
                FieldName != null &&
                FieldName.Equals(other.FieldName)
            ) &&
            (
                Direction == other.Direction ||
                Direction != null &&
                Direction.Equals(other.Direction)
            ) &&
            (
                Numeric == other.Numeric ||
                Numeric != null &&
                Numeric.Equals(other.Numeric)
            ) &&
            (
                AdditionalProperties == other.AdditionalProperties ||
                AdditionalProperties != null &&
                AdditionalProperties.SequenceEqual(other.AdditionalProperties)
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
            if (FieldName != null)
            {
                hash = hash * 59 + FieldName.GetHashCode();
            }

            if (Direction != null)
            {
                hash = hash * 59 + Direction.GetHashCode();
            }

            if (Numeric != null)
            {
                hash = hash * 59 + Numeric.GetHashCode();
            }

            if (AdditionalProperties != null)
            {
                hash = hash * 59 + AdditionalProperties.GetHashCode();
            }

            return hash;
        }
    }
}
