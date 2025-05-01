using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// DialerRulesetConfigChangeContactColumnToDataActionFieldMapping
/// </summary>
[DataContract]
public partial class DialerRulesetConfigChangeContactColumnToDataActionFieldMapping : IEquatable<DialerRulesetConfigChangeContactColumnToDataActionFieldMapping>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DialerRulesetConfigChangeContactColumnToDataActionFieldMapping" /> class.
    /// </summary>
    /// <param name="ContactColumnName">The name of a contact column whose data will be passed to the data action.</param>
    /// <param name="DataActionField">The name of an output field from the data action that the contact column data will be passed to.</param>
    /// <param name="AdditionalProperties">AdditionalProperties.</param>
    public DialerRulesetConfigChangeContactColumnToDataActionFieldMapping(string ContactColumnName = null, string DataActionField = null, Dictionary<string, object> AdditionalProperties = null)
    {
        this.ContactColumnName = ContactColumnName;
        this.DataActionField = DataActionField;
        this.AdditionalProperties = AdditionalProperties;

    }



    /// <summary>
    /// The name of a contact column whose data will be passed to the data action
    /// </summary>
    /// <value>The name of a contact column whose data will be passed to the data action</value>
    [DataMember(Name = "contactColumnName", EmitDefaultValue = false)]
    public string ContactColumnName { get; set; }



    /// <summary>
    /// The name of an output field from the data action that the contact column data will be passed to
    /// </summary>
    /// <value>The name of an output field from the data action that the contact column data will be passed to</value>
    [DataMember(Name = "dataActionField", EmitDefaultValue = false)]
    public string DataActionField { get; set; }



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
        sb.Append("class DialerRulesetConfigChangeContactColumnToDataActionFieldMapping {\n");

        sb.Append("  ContactColumnName: ").Append(ContactColumnName).Append("\n");
        sb.Append("  DataActionField: ").Append(DataActionField).Append("\n");
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
        return Equals(obj as DialerRulesetConfigChangeContactColumnToDataActionFieldMapping);
    }

    /// <summary>
    /// Returns true if DialerRulesetConfigChangeContactColumnToDataActionFieldMapping instances are equal
    /// </summary>
    /// <param name="other">Instance of DialerRulesetConfigChangeContactColumnToDataActionFieldMapping to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DialerRulesetConfigChangeContactColumnToDataActionFieldMapping other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ContactColumnName == other.ContactColumnName ||
                ContactColumnName != null &&
                ContactColumnName.Equals(other.ContactColumnName)
            ) &&
            (
                DataActionField == other.DataActionField ||
                DataActionField != null &&
                DataActionField.Equals(other.DataActionField)
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
            if (ContactColumnName != null)
            {
                hash = hash * 59 + ContactColumnName.GetHashCode();
            }

            if (DataActionField != null)
            {
                hash = hash * 59 + DataActionField.GetHashCode();
            }

            if (AdditionalProperties != null)
            {
                hash = hash * 59 + AdditionalProperties.GetHashCode();
            }

            return hash;
        }
    }
}
