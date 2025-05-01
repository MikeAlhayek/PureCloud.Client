using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DialerCampaignConfigChangePhoneColumn
/// </summary>
[DataContract]
public partial class DialerCampaignConfigChangePhoneColumn : IEquatable<DialerCampaignConfigChangePhoneColumn>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DialerCampaignConfigChangePhoneColumn" /> class.
    /// </summary>
    /// <param name="ColumnName">The name of the phone column.</param>
    /// <param name="Type">The type of the phone column, for example, &#39;cell&#39; or &#39;home&#39;.</param>
    /// <param name="AdditionalProperties">AdditionalProperties.</param>
    public DialerCampaignConfigChangePhoneColumn(string ColumnName = null, string Type = null, Dictionary<string, object> AdditionalProperties = null)
    {
        this.ColumnName = ColumnName;
        this.Type = Type;
        this.AdditionalProperties = AdditionalProperties;

    }



    /// <summary>
    /// The name of the phone column
    /// </summary>
    /// <value>The name of the phone column</value>
    [DataMember(Name = "columnName", EmitDefaultValue = false)]
    public string ColumnName { get; set; }



    /// <summary>
    /// The type of the phone column, for example, &#39;cell&#39; or &#39;home&#39;
    /// </summary>
    /// <value>The type of the phone column, for example, &#39;cell&#39; or &#39;home&#39;</value>
    [DataMember(Name = "type", EmitDefaultValue = false)]
    public string Type { get; set; }



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
        sb.Append("class DialerCampaignConfigChangePhoneColumn {\n");

        sb.Append("  ColumnName: ").Append(ColumnName).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
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
        return this.Equals(obj as DialerCampaignConfigChangePhoneColumn);
    }

    /// <summary>
    /// Returns true if DialerCampaignConfigChangePhoneColumn instances are equal
    /// </summary>
    /// <param name="other">Instance of DialerCampaignConfigChangePhoneColumn to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DialerCampaignConfigChangePhoneColumn other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.ColumnName == other.ColumnName ||
                this.ColumnName != null &&
                this.ColumnName.Equals(other.ColumnName)
            ) &&
            (
                this.Type == other.Type ||
                this.Type != null &&
                this.Type.Equals(other.Type)
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
            if (this.ColumnName != null)
            {
                hash = hash * 59 + this.ColumnName.GetHashCode();
            }

            if (this.Type != null)
            {
                hash = hash * 59 + this.Type.GetHashCode();
            }

            if (this.AdditionalProperties != null)
            {
                hash = hash * 59 + this.AdditionalProperties.GetHashCode();
            }

            return hash;
        }
    }
}
