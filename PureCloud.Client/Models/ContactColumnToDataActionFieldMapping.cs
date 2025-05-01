using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ContactColumnToDataActionFieldMapping
/// </summary>
[DataContract]
public partial class ContactColumnToDataActionFieldMapping : IEquatable<ContactColumnToDataActionFieldMapping>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="ContactColumnToDataActionFieldMapping" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ContactColumnToDataActionFieldMapping() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ContactColumnToDataActionFieldMapping" /> class.
    /// </summary>
    /// <param name="ContactColumnName">The name of a contact column whose data will be passed to the data action (required).</param>
    /// <param name="DataActionField">The name of an input field from the data action that the contact column data will be passed to (required).</param>
    public ContactColumnToDataActionFieldMapping(string ContactColumnName = null, string DataActionField = null)
    {
        this.ContactColumnName = ContactColumnName;
        this.DataActionField = DataActionField;

    }



    /// <summary>
    /// The name of a contact column whose data will be passed to the data action
    /// </summary>
    /// <value>The name of a contact column whose data will be passed to the data action</value>
    [DataMember(Name = "contactColumnName", EmitDefaultValue = false)]
    public string ContactColumnName { get; set; }



    /// <summary>
    /// The name of an input field from the data action that the contact column data will be passed to
    /// </summary>
    /// <value>The name of an input field from the data action that the contact column data will be passed to</value>
    [DataMember(Name = "dataActionField", EmitDefaultValue = false)]
    public string DataActionField { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ContactColumnToDataActionFieldMapping {\n");

        sb.Append("  ContactColumnName: ").Append(ContactColumnName).Append("\n");
        sb.Append("  DataActionField: ").Append(DataActionField).Append("\n");
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
        return Equals(obj as ContactColumnToDataActionFieldMapping);
    }

    /// <summary>
    /// Returns true if ContactColumnToDataActionFieldMapping instances are equal
    /// </summary>
    /// <param name="other">Instance of ContactColumnToDataActionFieldMapping to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ContactColumnToDataActionFieldMapping other)
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

            return hash;
        }
    }
}
