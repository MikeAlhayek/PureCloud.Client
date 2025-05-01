using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DialerContactlistConfigChangeContactPhoneNumberColumn
/// </summary>
[DataContract]
public partial class DialerContactlistConfigChangeContactPhoneNumberColumn : IEquatable<DialerContactlistConfigChangeContactPhoneNumberColumn>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DialerContactlistConfigChangeContactPhoneNumberColumn" /> class.
    /// </summary>
    /// <param name="ColumnName">name of the phone column.</param>
    /// <param name="Type">type of the phone column, for example, &#39;cell&#39; or &#39;home&#39;.</param>
    /// <param name="CallableTimeColumn">name of the column indicating the timezone to be considered for determining callable times.</param>
    /// <param name="AdditionalProperties">AdditionalProperties.</param>
    public DialerContactlistConfigChangeContactPhoneNumberColumn(string ColumnName = null, string Type = null, string CallableTimeColumn = null, Dictionary<string, Object> AdditionalProperties = null)
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
    [DataMember(Name = "columnName", EmitDefaultValue = false)]
    public string ColumnName { get; set; }



    /// <summary>
    /// type of the phone column, for example, &#39;cell&#39; or &#39;home&#39;
    /// </summary>
    /// <value>type of the phone column, for example, &#39;cell&#39; or &#39;home&#39;</value>
    [DataMember(Name = "type", EmitDefaultValue = false)]
    public string Type { get; set; }



    /// <summary>
    /// name of the column indicating the timezone to be considered for determining callable times
    /// </summary>
    /// <value>name of the column indicating the timezone to be considered for determining callable times</value>
    [DataMember(Name = "callableTimeColumn", EmitDefaultValue = false)]
    public string CallableTimeColumn { get; set; }



    /// <summary>
    /// Gets or Sets AdditionalProperties
    /// </summary>
    [DataMember(Name = "additionalProperties", EmitDefaultValue = false)]
    public Dictionary<string, Object> AdditionalProperties { get; set; }


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
        return this.Equals(obj as DialerContactlistConfigChangeContactPhoneNumberColumn);
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
                this.CallableTimeColumn == other.CallableTimeColumn ||
                this.CallableTimeColumn != null &&
                this.CallableTimeColumn.Equals(other.CallableTimeColumn)
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

            if (this.CallableTimeColumn != null)
            {
                hash = hash * 59 + this.CallableTimeColumn.GetHashCode();
            }

            if (this.AdditionalProperties != null)
            {
                hash = hash * 59 + this.AdditionalProperties.GetHashCode();
            }

            return hash;
        }
    }
}
