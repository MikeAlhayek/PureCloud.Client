using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// OpenActionFields
/// </summary>
[DataContract]
public partial class OpenActionFields : IEquatable<OpenActionFields>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="OpenActionFields" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected OpenActionFields() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="OpenActionFields" /> class.
    /// </summary>
    /// <param name="OpenAction">The specific type of the open action. (required).</param>
    /// <param name="ConfigurationFields">Custom fields defined in the schema referenced by the open action type selected..</param>
    public OpenActionFields(DomainEntityRef OpenAction = null, Dictionary<string, object> ConfigurationFields = null)
    {
        this.OpenAction = OpenAction;
        this.ConfigurationFields = ConfigurationFields;

    }



    /// <summary>
    /// The specific type of the open action.
    /// </summary>
    /// <value>The specific type of the open action.</value>
    [DataMember(Name = "openAction", EmitDefaultValue = false)]
    public DomainEntityRef OpenAction { get; set; }



    /// <summary>
    /// Custom fields defined in the schema referenced by the open action type selected.
    /// </summary>
    /// <value>Custom fields defined in the schema referenced by the open action type selected.</value>
    [DataMember(Name = "configurationFields", EmitDefaultValue = false)]
    public Dictionary<string, object> ConfigurationFields { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class OpenActionFields {\n");

        sb.Append("  OpenAction: ").Append(OpenAction).Append("\n");
        sb.Append("  ConfigurationFields: ").Append(ConfigurationFields).Append("\n");
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
        return Equals(obj as OpenActionFields);
    }

    /// <summary>
    /// Returns true if OpenActionFields instances are equal
    /// </summary>
    /// <param name="other">Instance of OpenActionFields to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(OpenActionFields other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                OpenAction == other.OpenAction ||
                OpenAction != null &&
                OpenAction.Equals(other.OpenAction)
            ) &&
            (
                ConfigurationFields == other.ConfigurationFields ||
                ConfigurationFields != null &&
                ConfigurationFields.SequenceEqual(other.ConfigurationFields)
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
            if (OpenAction != null)
            {
                hash = hash * 59 + OpenAction.GetHashCode();
            }

            if (ConfigurationFields != null)
            {
                hash = hash * 59 + ConfigurationFields.GetHashCode();
            }

            return hash;
        }
    }
}
