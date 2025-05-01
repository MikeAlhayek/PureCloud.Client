using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

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
        return Equals(obj as MetadataProperty);
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
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                Displayname == other.Displayname ||
                Displayname != null &&
                Displayname.Equals(other.Displayname)
            ) &&
            (
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
            ) &&
            (
                Sensitive == other.Sensitive ||
                Sensitive != null &&
                Sensitive.Equals(other.Sensitive)
            ) &&
            (
                Help == other.Help ||
                Help != null &&
                Help.Equals(other.Help)
            ) &&
            (
                Default == other.Default ||
                Default != null &&
                Default.Equals(other.Default)
            ) &&
            (
                Enum == other.Enum ||
                Enum != null &&
                Enum.SequenceEqual(other.Enum)
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
            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (Displayname != null)
            {
                hash = hash * 59 + Displayname.GetHashCode();
            }

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (Sensitive != null)
            {
                hash = hash * 59 + Sensitive.GetHashCode();
            }

            if (Help != null)
            {
                hash = hash * 59 + Help.GetHashCode();
            }

            if (Default != null)
            {
                hash = hash * 59 + Default.GetHashCode();
            }

            if (Enum != null)
            {
                hash = hash * 59 + Enum.GetHashCode();
            }

            return hash;
        }
    }
}
