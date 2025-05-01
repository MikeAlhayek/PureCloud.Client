using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model;

/// <summary>
/// Data property required as input for installing an accelerator
/// </summary>
[DataContract]
public partial class MetadataProperty : IEquatable<MetadataProperty>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MetadataProperty" /> class.
    /// </summary>
    public MetadataProperty()
    {

    }



    /// <summary>
    /// the data type of the input property
    /// </summary>
    /// <value>the data type of the input property</value>
    [DataMember(Name = "type", EmitDefaultValue = false)]
    public string Type { get; private set; }



    /// <summary>
    /// user-friendly name of the input property
    /// </summary>
    /// <value>user-friendly name of the input property</value>
    [DataMember(Name = "displayname", EmitDefaultValue = false)]
    public string Displayname { get; private set; }



    /// <summary>
    /// brief description of the input property
    /// </summary>
    /// <value>brief description of the input property</value>
    [DataMember(Name = "description", EmitDefaultValue = false)]
    public string Description { get; private set; }



    /// <summary>
    /// whether the property&#39;s value should be hidden from display
    /// </summary>
    /// <value>whether the property&#39;s value should be hidden from display</value>
    [DataMember(Name = "sensitive", EmitDefaultValue = false)]
    public string Sensitive { get; private set; }



    /// <summary>
    /// optional URL with addition information about the input property
    /// </summary>
    /// <value>optional URL with addition information about the input property</value>
    [DataMember(Name = "help", EmitDefaultValue = false)]
    public string Help { get; private set; }



    /// <summary>
    /// optional default value of the input property
    /// </summary>
    /// <value>optional default value of the input property</value>
    [DataMember(Name = "default", EmitDefaultValue = false)]
    public string Default { get; private set; }



    /// <summary>
    /// set of possible values if the input property is an enumeration
    /// </summary>
    /// <value>set of possible values if the input property is an enumeration</value>
    [DataMember(Name = "enum", EmitDefaultValue = false)]
    public List<string> Enum { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class MetadataProperty {\n");

        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Displayname: ").Append(Displayname).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  Sensitive: ").Append(Sensitive).Append("\n");
        sb.Append("  Help: ").Append(Help).Append("\n");
        sb.Append("  Default: ").Append(Default).Append("\n");
        sb.Append("  Enum: ").Append(Enum).Append("\n");
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
        return this.Equals(obj as MetadataProperty);
    }

    /// <summary>
    /// Returns true if MetadataProperty instances are equal
    /// </summary>
    /// <param name="other">Instance of MetadataProperty to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(MetadataProperty other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.Type == other.Type ||
                this.Type != null &&
                this.Type.Equals(other.Type)
            ) &&
            (
                this.Displayname == other.Displayname ||
                this.Displayname != null &&
                this.Displayname.Equals(other.Displayname)
            ) &&
            (
                this.Description == other.Description ||
                this.Description != null &&
                this.Description.Equals(other.Description)
            ) &&
            (
                this.Sensitive == other.Sensitive ||
                this.Sensitive != null &&
                this.Sensitive.Equals(other.Sensitive)
            ) &&
            (
                this.Help == other.Help ||
                this.Help != null &&
                this.Help.Equals(other.Help)
            ) &&
            (
                this.Default == other.Default ||
                this.Default != null &&
                this.Default.Equals(other.Default)
            ) &&
            (
                this.Enum == other.Enum ||
                this.Enum != null &&
                this.Enum.SequenceEqual(other.Enum)
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
            if (this.Type != null)
            {
                hash = hash * 59 + this.Type.GetHashCode();
            }

            if (this.Displayname != null)
            {
                hash = hash * 59 + this.Displayname.GetHashCode();
            }

            if (this.Description != null)
            {
                hash = hash * 59 + this.Description.GetHashCode();
            }

            if (this.Sensitive != null)
            {
                hash = hash * 59 + this.Sensitive.GetHashCode();
            }

            if (this.Help != null)
            {
                hash = hash * 59 + this.Help.GetHashCode();
            }

            if (this.Default != null)
            {
                hash = hash * 59 + this.Default.GetHashCode();
            }

            if (this.Enum != null)
            {
                hash = hash * 59 + this.Enum.GetHashCode();
            }

            return hash;
        }
    }
}
