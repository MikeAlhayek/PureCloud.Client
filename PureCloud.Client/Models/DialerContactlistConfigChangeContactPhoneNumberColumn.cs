using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DialerContactlistConfigChangeContactPhoneNumberColumn
/// </summary>

public partial class DialerContactlistConfigChangeContactPhoneNumberColumn : IEquatable<DialerContactlistConfigChangeContactPhoneNumberColumn>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DialerContactlistConfigChangeContactPhoneNumberColumn" /> class.
    /// </summary>
    /// <param name="ColumnName">name of the phone column.</param>
    /// <param name="Type">type of the phone column, for example, &#39;cell&#39; or &#39;home&#39;.</param>
    /// <param name="CallableTimeColumn">name of the column indicating the timezone to be considered for determining callable times.</param>
    /// <param name="AdditionalProperties">AdditionalProperties.</param>
    public DialerContactlistConfigChangeContactPhoneNumberColumn(string ColumnName = null, string Type = null, string CallableTimeColumn = null, Dictionary<string, object> AdditionalProperties = null)
    {
        this.ColumnName = ColumnName;
        this.Type = Type;
        this.CallableTimeColumn = CallableTimeColumn;
        this.AdditionalProperties = AdditionalProperties;

    }



    /// <summary>
    /// name of the phone column
    /// </summary>
    /// <value>name of the phone column</value>
    [JsonPropertyName("columnName")]
    public string ColumnName { get; set; }



    /// <summary>
    /// type of the phone column, for example, &#39;cell&#39; or &#39;home&#39;
    /// </summary>
    /// <value>type of the phone column, for example, &#39;cell&#39; or &#39;home&#39;</value>
    [JsonPropertyName("type")]
    public string Type { get; set; }



    /// <summary>
    /// name of the column indicating the timezone to be considered for determining callable times
    /// </summary>
    /// <value>name of the column indicating the timezone to be considered for determining callable times</value>
    [JsonPropertyName("callableTimeColumn")]
    public string CallableTimeColumn { get; set; }



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
        sb.Append("class DialerContactlistConfigChangeContactPhoneNumberColumn {\n");

        sb.Append("  ColumnName: ").Append(ColumnName).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  CallableTimeColumn: ").Append(CallableTimeColumn).Append("\n");
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
        return Equals(obj as DialerContactlistConfigChangeContactPhoneNumberColumn);
    }

    /// <summary>
    /// Returns true if DialerContactlistConfigChangeContactPhoneNumberColumn instances are equal
    /// </summary>
    /// <param name="other">Instance of DialerContactlistConfigChangeContactPhoneNumberColumn to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DialerContactlistConfigChangeContactPhoneNumberColumn other)
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
                CallableTimeColumn == other.CallableTimeColumn ||
                CallableTimeColumn != null &&
                CallableTimeColumn.Equals(other.CallableTimeColumn)
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

            if (CallableTimeColumn != null)
            {
                hash = hash * 59 + CallableTimeColumn.GetHashCode();
            }

            if (AdditionalProperties != null)
            {
                hash = hash * 59 + AdditionalProperties.GetHashCode();
            }

            return hash;
        }
    }
}
