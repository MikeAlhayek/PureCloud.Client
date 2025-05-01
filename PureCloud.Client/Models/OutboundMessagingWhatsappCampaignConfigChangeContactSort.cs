using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// OutboundMessagingWhatsappCampaignConfigChangeContactSort
/// </summary>
[DataContract]
public partial class OutboundMessagingWhatsappCampaignConfigChangeContactSort : IEquatable<OutboundMessagingWhatsappCampaignConfigChangeContactSort>
{
    /// <summary>
    /// Gets or Sets Direction
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
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
    [DataMember(Name = "direction", EmitDefaultValue = false)]
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
    [DataMember(Name = "fieldName", EmitDefaultValue = false)]
    public string FieldName { get; set; }





    /// <summary>
    /// Whether that column contains numeric data
    /// </summary>
    /// <value>Whether that column contains numeric data</value>
    [DataMember(Name = "numeric", EmitDefaultValue = false)]
    public bool? Numeric { get; set; }



    /// <summary>
    /// Gets or Sets AdditionalProperties
    /// </summary>
    [DataMember(Name = "additionalProperties", EmitDefaultValue = false)]
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
        return this.Equals(obj as OutboundMessagingWhatsappCampaignConfigChangeContactSort);
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
                this.FieldName == other.FieldName ||
                this.FieldName != null &&
                this.FieldName.Equals(other.FieldName)
            ) &&
            (
                this.Direction == other.Direction ||
                this.Direction != null &&
                this.Direction.Equals(other.Direction)
            ) &&
            (
                this.Numeric == other.Numeric ||
                this.Numeric != null &&
                this.Numeric.Equals(other.Numeric)
            ) &&
            (
                this.AdditionalProperties == other.AdditionalProperties ||
                this.AdditionalProperties != null &&
                this.AdditionalProperties.SequenceEqual(other.AdditionalProperties)
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
            if (this.FieldName != null)
            {
                hash = hash * 59 + this.FieldName.GetHashCode();
            }

            if (this.Direction != null)
            {
                hash = hash * 59 + this.Direction.GetHashCode();
            }

            if (this.Numeric != null)
            {
                hash = hash * 59 + this.Numeric.GetHashCode();
            }

            if (this.AdditionalProperties != null)
            {
                hash = hash * 59 + this.AdditionalProperties.GetHashCode();
            }

            return hash;
        }
    }
}
