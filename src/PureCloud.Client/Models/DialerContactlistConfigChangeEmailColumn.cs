using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DialerContactlistConfigChangeEmailColumn
/// </summary>

public partial class DialerContactlistConfigChangeEmailColumn : IEquatable<DialerContactlistConfigChangeEmailColumn>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DialerContactlistConfigChangeEmailColumn" /> class.
    /// </summary>
    /// <param name="ColumnName">The name of the email address column.</param>
    /// <param name="Type">The type of the email address column, for example, &#39;work&#39; or &#39;home&#39;.</param>
    /// <param name="AdditionalProperties">AdditionalProperties.</param>
    public DialerContactlistConfigChangeEmailColumn(string ColumnName = null, string Type = null, Dictionary<string, object> AdditionalProperties = null)
    {
        this.ColumnName = ColumnName;
        this.Type = Type;
        this.AdditionalProperties = AdditionalProperties;

    }



    /// <summary>
    /// The name of the email address column
    /// </summary>
    /// <value>The name of the email address column</value>
    [JsonPropertyName("columnName")]
    public string ColumnName { get; set; }



    /// <summary>
    /// The type of the email address column, for example, &#39;work&#39; or &#39;home&#39;
    /// </summary>
    /// <value>The type of the email address column, for example, &#39;work&#39; or &#39;home&#39;</value>
    [JsonPropertyName("type")]
    public string Type { get; set; }



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
        sb.Append("class DialerContactlistConfigChangeEmailColumn {\n");

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
        return Equals(obj as DialerContactlistConfigChangeEmailColumn);
    }

    /// <summary>
    /// Returns true if DialerContactlistConfigChangeEmailColumn instances are equal
    /// </summary>
    /// <param name="other">Instance of DialerContactlistConfigChangeEmailColumn to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DialerContactlistConfigChangeEmailColumn other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ColumnName == other.ColumnName ||
                ColumnName != null &&
                ColumnName.Equals(other.ColumnName)
            ) &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
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
            if (ColumnName != null)
            {
                hash = hash * 59 + ColumnName.GetHashCode();
            }

            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (AdditionalProperties != null)
            {
                hash = hash * 59 + AdditionalProperties.GetHashCode();
            }

            return hash;
        }
    }
}
